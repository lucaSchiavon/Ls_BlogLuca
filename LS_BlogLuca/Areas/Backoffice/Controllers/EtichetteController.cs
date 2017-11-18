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
    public class EtichetteController : Controller
    {
        private ModelLucaBlog db = new ModelLucaBlog();

        // GET: Backoffice/Categorie
        public ActionResult Index()
        {
            var etichette = db.Etichette;
            return View(etichette.ToList());
        }

       
        public ActionResult Create()
        {
           
            Etichette ObjEtichette = new Etichette();
            return View("Edit", ObjEtichette);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Etichette etichette)
        {
            if (ModelState.IsValid)
            {
                db.Etichette.Add(etichette);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           
            return View(etichette);
        }
       

        // GET: Backoffice/Articoli/Edit/5
        //[ValidateInput(false)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Etichette etichette = db.Etichette.Find(id);
            if (etichette == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEtichette = new SelectList(db.Categorie, "IdEtichette", "Etichette", etichette.IdEtichetta);
            return View(etichette);
        }

        // POST: Backoffice/Articoli/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Etichette etichette)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etichette).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            return View(etichette);
        }

       
        // POST: Backoffice/Articoli/Delete/5
      
        public ActionResult DeleteDirect(int id)
        {
            Etichette etichette = db.Etichette.Find(id);
            db.Etichette.Remove(etichette);
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
