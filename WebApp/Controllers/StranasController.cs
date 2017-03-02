using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp;

namespace WebApp.Controllers
{
    public class StranasController : Controller
    {
        private OooPs14_dbEntities2 db = new OooPs14_dbEntities2();

        // GET: Stranas
        public ActionResult Index()
        {
            return View(db.Strana.ToList());
        }

        // GET: Stranas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Strana strana = db.Strana.Find(id);
            if (strana == null)
            {
                return HttpNotFound();
            }
            return View(strana);
        }

        // GET: Stranas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stranas/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_strana,name_stran,kod_stran,post_index_stran")] Strana strana)
        {
            if (ModelState.IsValid)
            {
                db.Strana.Add(strana);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(strana);
        }

        // GET: Stranas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Strana strana = db.Strana.Find(id);
            if (strana == null)
            {
                return HttpNotFound();
            }
            return View(strana);
        }

        // POST: Stranas/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_strana,name_stran,kod_stran,post_index_stran")] Strana strana)
        {
            if (ModelState.IsValid)
            {
                db.Entry(strana).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(strana);
        }

        // GET: Stranas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Strana strana = db.Strana.Find(id);
            if (strana == null)
            {
                return HttpNotFound();
            }
            return View(strana);
        }

        // POST: Stranas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Strana strana = db.Strana.Find(id);
            db.Strana.Remove(strana);
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
