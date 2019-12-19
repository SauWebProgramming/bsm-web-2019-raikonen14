using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using E_Ticaret_Süt_Ürünleri.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using E_Ticaret_Süt_Ürünleri.Identify;

namespace E_Ticaret_Süt_Ürünleri.Identity
{
    public class IdentityInitializer :CreateDatabaseIfNotExists<IdentitiyDataContext>
    {
        protected override void  Seed( IdentitiyDataContext context )
        {
            //Roller
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name="admin",Aciklama="admin rolü"};
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Aciklama = "user rolü" }; ;
                manager.Create(role);
            }
            if (!context.Users.Any(i => i.Isim == "omer"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() {Isim= "omer",Soyisim="isik",UserName="raikonen14",Email="isikomer373@gmail.com" };
                manager.Create(user,"112233");
                manager.AddToRole(user.Id,"admin");
                manager.AddToRole(user.Id, "user");
            }
            if (!context.Users.Any(i => i.Isim == "talha"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Isim = "talha", Soyisim = "sahin", UserName = "talhasahin", Email = "talhasahin@gmail.com" };
                manager.Create(user, "112233");
                manager.AddToRole(user.Id, "user");
            }
         


            //User

            base.Seed(context);
        }
    }
}