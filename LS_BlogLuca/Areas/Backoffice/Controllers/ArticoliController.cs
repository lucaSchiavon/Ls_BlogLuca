using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LS_BlogLuca.EF;

namespace LS_BlogLuca.Areas.Backoffice.Controllers
{
    public class ArticoliController : Controller
    {
        private ModelLucaBlog db = new ModelLucaBlog();

        // GET: Backoffice/Articoli
        public ActionResult Index()
        {
         
            var articoli = db.Articoli.Include(a => a.Categorie);
            return View(articoli.ToList());
            
        }

        //// GET: Backoffice/Articoli/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Articoli articoli = db.Articoli.Find(id);
        //    if (articoli == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(articoli);
        //}

        //// GET: Backoffice/Articoli/Create
        //public ActionResult Create()
        //{
        //    ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria");
        //    return View();
        //}

        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria");
            Articoli ObjArticoli = new Articoli();
            return View("Edit", ObjArticoli);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdArticolo,IdCategoria,Titolo,Titolo_en,Contenuti,Contenuti_en,Attivo,DataInserimento,Tags")] Articoli articoli)
        {
            if (ModelState.IsValid)
            {
                db.Articoli.Add(articoli);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria", articoli.IdCategoria);
            return View(articoli);
        }
        //// POST: Backoffice/Articoli/Create
        //// Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        //// Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "IdArticolo,IdCategoria,Titolo,Titolo_en,Contenuti,Contenuti_en,Attivo,DataInserimento,Tags")] Articoli articoli)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Articoli.Add(articoli);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria", articoli.IdCategoria);
        //    return View(articoli);
        //}

        // GET: Backoffice/Articoli/Edit/5
        //[ValidateInput(false)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Articoli articoli = db.Articoli.Find(id);
            if (articoli == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria", articoli.IdCategoria);
            return View(articoli);
        }

        // POST: Backoffice/Articoli/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdArticolo,IdCategoria,Titolo,Titolo_en,Contenuti,Contenuti_en,Attivo,DataInserimento,Tags")] Articoli articoli)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articoli).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria", articoli.IdCategoria);
            return View(articoli);
        }

        //// GET: Backoffice/Articoli/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Articoli articoli = db.Articoli.Find(id);
        //    if (articoli == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(articoli);
        //}

        //// POST: Backoffice/Articoli/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Articoli articoli = db.Articoli.Find(id);
        //    db.Articoli.Remove(articoli);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        // POST: Backoffice/Articoli/Delete/5
      
        public ActionResult DeleteDirect(int id)
        {
            Categorie categorie = db.Categorie.Find(id);
            db.Categorie.Remove(categorie);
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
