using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Ticaret_Süt_Ürünleri.Entity;

namespace E_Ticaret_Süt_Ürünleri.Controllers
{
    public class KategoriController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Kategori
        public ActionResult Index()
        {
            return View(db.Katagoriler.ToList());
        }

        // GET: Kategori/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Katagori katagori = db.Katagoriler.Find(id);
            if (katagori == null)
            {
                return HttpNotFound();
            }
            return View(katagori);
        }

        // GET: Kategori/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kategori/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Isim,Aciklama")] Katagori katagori)
        {
            if (ModelState.IsValid)
            {
                db.Katagoriler.Add(katagori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(katagori);
        }

        // GET: Kategori/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Katagori katagori = db.Katagoriler.Find(id);
            if (katagori == null)
            {
                return HttpNotFound();
            }
            return View(katagori);
        }

        // POST: Kategori/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Isim,Aciklama")] Katagori katagori)
        {
            if (ModelState.IsValid)
            {
                db.Entry(katagori).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(katagori);
        }

        // GET: Kategori/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Katagori katagori = db.Katagoriler.Find(id);
            if (katagori == null)
            {
                return HttpNotFound();
            }
            return View(katagori);
        }

        // POST: Kategori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Katagori katagori = db.Katagoriler.Find(id);
            db.Katagoriler.Remove(katagori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
