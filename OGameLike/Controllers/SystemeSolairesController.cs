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
    public class SystemeSolairesController : Controller
    {
        private Context db = new Context();

        // GET: SystemeSolaires
        public ActionResult Index()
        {
            return View(db.SystemeSolaires.ToList());
        }

        // GET: SystemeSolaires/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemeSolaire systemeSolaire = db.SystemeSolaires.Find(id);
            if (systemeSolaire == null)
            {
                return HttpNotFound();
            }
            return View(systemeSolaire);
        }

        // GET: SystemeSolaires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemeSolaires/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] SystemeSolaire systemeSolaire)
        {
            if (ModelState.IsValid)
            {
                db.SystemeSolaires.Add(systemeSolaire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(systemeSolaire);
        }

        // GET: SystemeSolaires/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemeSolaire systemeSolaire = db.SystemeSolaires.Find(id);
            if (systemeSolaire == null)
            {
                return HttpNotFound();
            }
            return View(systemeSolaire);
        }

        // POST: SystemeSolaires/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] SystemeSolaire systemeSolaire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(systemeSolaire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(systemeSolaire);
        }

        // GET: SystemeSolaires/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SystemeSolaire systemeSolaire = db.SystemeSolaires.Find(id);
            if (systemeSolaire == null)
            {
                return HttpNotFound();
            }
            return View(systemeSolaire);
        }

        // POST: SystemeSolaires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SystemeSolaire systemeSolaire = db.SystemeSolaires.Find(id);
            db.SystemeSolaires.Remove(systemeSolaire);
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
