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
    public class OtdelyController : Controller
    {
        private OooPs14_dbEntities2 db = new OooPs14_dbEntities2();

        // GET: Otdely
        public ActionResult Index()
        {
            var otdely = db.Otdely.Include(o => o.Sotrudniki);
            return View(otdely.ToList());
        }

        // GET: Otdely/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Otdely otdely = db.Otdely.Find(id);
            if (otdely == null)
            {
                return HttpNotFound();
            }
            return View(otdely);
        }

        // GET: Otdely/Create
        public ActionResult Create()
        {
            ViewBag.id_nach = new SelectList(db.Sotrudniki, "id_sotr", "name_sotr");
            return View();
        }

        // POST: Otdely/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_otd,name_otd,id_otd_parent,date_birth,date_death,id_nach")] Otdely otdely)
        {
            if (ModelState.IsValid)
            {
                db.Otdely.Add(otdely);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_nach = new SelectList(db.Sotrudniki, "id_sotr", "name_sotr", otdely.id_nach);
            return View(otdely);
        }

        // GET: Otdely/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Otdely otdely = db.Otdely.Find(id);
            if (otdely == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_nach = new SelectList(db.Sotrudniki, "id_sotr", "name_sotr", otdely.id_nach);
            return View(otdely);
        }

        // POST: Otdely/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_otd,name_otd,id_otd_parent,date_birth,date_death,id_nach")] Otdely otdely)
        {
            if (ModelState.IsValid)
            {
                db.Entry(otdely).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_nach = new SelectList(db.Sotrudniki, "id_sotr", "name_sotr", otdely.id_nach);
            return View(otdely);
        }

        // GET: Otdely/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Otdely otdely = db.Otdely.Find(id);
            if (otdely == null)
            {
                return HttpNotFound();
            }
            return View(otdely);
        }

        // POST: Otdely/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Otdely otdely = db.Otdely.Find(id);
            db.Otdely.Remove(otdely);
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
