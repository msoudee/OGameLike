using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OGameLike.Data;
using OGameLikeBO;

namespace OGameLike.Controllers
{
    public class RessourcesController : Controller
    {
        private Context db = new Context();

        // GET: Ressources
        public ActionResult Index()
        {
            return View(db.Ressources.ToList());
        }

        // GET: Ressources/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // GET: Ressources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ressources/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom,DerniereQuantite,DerniereMAJ")] Ressource ressource)
        {
            if (ModelState.IsValid)
            {
                db.Ressources.Add(ressource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ressource);
        }

        // GET: Ressources/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // POST: Ressources/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom,DerniereQuantite,DerniereMAJ")] Ressource ressource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ressource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ressource);
        }

        // GET: Ressources/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // POST: Ressources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Ressource ressource = db.Ressources.Find(id);
            db.Ressources.Remove(ressource);
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
