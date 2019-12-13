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
            var urunler = _context.Urunler
                .Where(i => i.Anasayfa && i.Aktif)
                .Select(i => new Models.ProductModel()
                {
                    Id = i.Id,
                    Isim = i.Isim,
                    Aciklama = i.Aciklama.Length > 50 ? i.Aciklama.Substring(0, 47) + "..." : i.Aciklama,
                    Fiyat = i.Fiyat,
                    Stok = i.Stok,
                    Resim = i.Resim,
                    KatagoriId = i.KatagoriId
                }).ToList();

            return View(urunler);
        }
        public ActionResult Detay(int id )
        {
            return View(_context.Urunler.Where(i =>i.Id==id).FirstOrDefault());
        }
        public ActionResult Liste(int? id)
        {
            var urunler = _context.Urunler
                .Where(i => i.Anasayfa && i.Aktif)
                .Select(i => new Models.ProductModel()
                {
                    Id = i.Id,
                    Isim = i.Isim,
                    Aciklama = i.Aciklama.Length > 50 ? i.Aciklama.Substring(0, 47) + "..." : i.Aciklama,
                    Fiyat = i.Fiyat,
                    Stok = i.Stok,
                    Resim = i.Resim,
                    KatagoriId = i.KatagoriId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.KatagoriId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Katagoriler.ToList());
        }
    }
}