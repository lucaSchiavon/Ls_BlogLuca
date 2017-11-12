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
    public class CategorieController : Controller
    {
        private ModelLucaBlog db = new ModelLucaBlog();

        // GET: Backoffice/Categorie
        public ActionResult Index()
        {
            var categorie = db.Categorie;
            return View(categorie.ToList());
        }

        // GET: Backoffice/Categorie/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Categorie categorie = db.Categorie.Find(id);
        //    if (categorie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(categorie);
        //}

        

        public ActionResult Create()
        {
           
            Categorie ObjCategorie = new Categorie();
            return View("Edit", ObjCategorie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorie categorie)
        {
            if (ModelState.IsValid)
            {
                db.Categorie.Add(categorie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           
            return View(categorie);
        }
       

        // GET: Backoffice/Articoli/Edit/5
        //[ValidateInput(false)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categorie categorie = db.Categorie.Find(id);
            if (categorie == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.Categorie, "IdCategoria", "Categoria", categorie.IdCategoria);
            return View(categorie);
        }

        // POST: Backoffice/Articoli/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie categorie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            return View(categorie);
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
