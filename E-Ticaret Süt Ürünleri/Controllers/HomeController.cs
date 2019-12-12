using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Ticaret_Süt_Ürünleri.Entity;


namespace E_Ticaret_Süt_Ürünleri.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            return View(_context.Urunler.Where(i => i.Anasayfa && i.Aktif).ToList());
        }
        public ActionResult Detay(int id )
        {
            return View(_context.Urunler.Where(i =>i.Id==id).FirstOrDefault());
        }
        public ActionResult Liste()
        {
            return View(_context.Urunler.Where(i => i.Aktif).ToList());
        }
    }
}