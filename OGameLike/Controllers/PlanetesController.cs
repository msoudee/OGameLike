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
    public class PlanetesController : Controller
    {
        private Context db = new Context();

        // GET: Planetes
        public ActionResult Index()
        {
            return View(db.Planetes.ToList());
        }

        // GET: Planetes/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planete planete = db.Planetes.Find(id);
            if (planete == null)
            {
                return HttpNotFound();
            }
            return View(planete);
        }

        // GET: Planetes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Planetes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,CaseNb")] Planete planete)
        {
            if (ModelState.IsValid)
            {
                db.Planetes.Add(planete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(planete);
        }

        // GET: Planetes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planete planete = db.Planetes.Find(id);
            if (planete == null)
            {
                return HttpNotFound();
            }
            return View(planete);
        }

        // POST: Planetes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,CaseNb")] Planete planete)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planete).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planete);
        }

        // GET: Planetes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Planete planete = db.Planetes.Find(id);
            if (planete == null)
            {
                return HttpNotFound();
            }
            return View(planete);
        }

        // POST: Planetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Planete planete = db.Planetes.Find(id);
            db.Planetes.Remove(planete);
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
