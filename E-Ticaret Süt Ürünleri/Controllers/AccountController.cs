using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using E_Ticaret_Süt_Ürünleri.Identify;
using Microsoft.AspNet.Identity.EntityFramework;
using E_Ticaret_Süt_Ürünleri.Models;
using Microsoft.Owin.Security;
using E_Ticaret_Süt_Ürünleri.Entity;
using E_Ticaret_Süt_Ürünleri.Identity;


namespace E_Ticaret_Süt_Ürünleri.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {

            var userStore = new UserStore<ApplicationUser>(new IdentitiyDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var rolStore = new RoleStore<ApplicationRole>(new IdentitiyDataContext());
            RoleManager = new RoleManager<ApplicationRole>(rolStore);
        }


        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt 
                var user = new ApplicationUser();
                user.Isim = model.Isim;
                user.Soyisim = model.Soyisim;
                user.Email = model.Email;
                user.UserName = model.KullaniciAd;


              var result = UserManager.Create(user, model.Sifre);

              if (result.Succeeded)
               {
                    //Kullanıcı oluşturuldu. Bir role atayabilirsiniz.
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }
                    return RedirectToAction("Login", "Account");
               }
                else
                {
                    ModelState.AddModelError("RegisterUserError","Kullanıcı oluşturma hatası.");
                }



            }
            return View(model);
        }








        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Login işlemleri
               var user = UserManager.Find(model.KullaniciAd, model.Sifre);
                if (user!=null)
                {
                    //var olan kullanıcıyı sisteme dahil et.
                    //applicationcookie oluştur sisteme bırak.
                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    (authProperties).IsPersistent = model.BeniHatirla;
                    authManager.SignIn(authProperties, identityclaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                       return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index","Home");

                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı bulunamadı..");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}