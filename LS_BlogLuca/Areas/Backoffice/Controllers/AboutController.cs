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
    public class AboutController : Controller
    {
        private ModelLucaBlog db = new ModelLucaBlog();

        //// GET: Backoffice/Categorie
        //public ActionResult Index()
        //{
        //    var categorie = db.Categorie;
        //    return View(categorie.ToList());
        //}

      

        //public ActionResult Create()
        //{
           
        //    Categorie ObjCategorie = new Categorie();
        //    return View("Edit", ObjCategorie);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Categorie categorie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Categorie.Add(categorie);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

           
        //    return View(categorie);
        //}
       

        // GET: Backoffice/Articoli/Edit/5
        //[ValidateInput(false)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            About about = db.About.Find(id);
            if (about == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdAbout = new SelectList(db.About, "IdAbout", "Titolo", about.IdAbout);
            return View(about);
        }

        // POST: Backoffice/Articoli/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                db.Entry(about).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("~/Backoffice/Home");
                
            }

           

            return View(about);
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
      
        //public ActionResult DeleteDirect(int id)
        //{
        //    Categorie categorie = db.Categorie.Find(id);
        //    db.Categorie.Remove(categorie);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
