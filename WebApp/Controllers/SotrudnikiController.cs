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
    public class SotrudnikiController : Controller
    {
        private OooPs14_dbEntities2 db = new OooPs14_dbEntities2();

        // GET: Sotrudniki
        public ActionResult Index()
        {
            var sotrudniki = db.Sotrudniki.Include(s => s.Dolzhnosti).Include(s => s.Otdely1);
            return View(sotrudniki.ToList());
        }

        // GET: Sotrudniki/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            return View(sotrudniki);
        }

        // GET: Sotrudniki/Create
        public ActionResult Create()
        {
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnosti, "id_dolzhn", "name_dolzhn");
            ViewBag.id_otd = new SelectList(db.Otdely, "id_otd", "name_otd");
            return View();
        }

        // POST: Sotrudniki/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_sotr,name_sotr,lastname_sotr,adress_sotr,email_sotr,phone_sotr,id_otd,data_priema,id_dolzhn")] Sotrudniki sotrudniki)
        {
            if (ModelState.IsValid)
            {
                db.Sotrudniki.Add(sotrudniki);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_dolzhn = new SelectList(db.Dolzhnosti, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdely, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // GET: Sotrudniki/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnosti, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdely, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // POST: Sotrudniki/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_sotr,name_sotr,lastname_sotr,adress_sotr,email_sotr,phone_sotr,id_otd,data_priema,id_dolzhn")] Sotrudniki sotrudniki)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sotrudniki).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_dolzhn = new SelectList(db.Dolzhnosti, "id_dolzhn", "name_dolzhn", sotrudniki.id_dolzhn);
            ViewBag.id_otd = new SelectList(db.Otdely, "id_otd", "name_otd", sotrudniki.id_otd);
            return View(sotrudniki);
        }

        // GET: Sotrudniki/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            if (sotrudniki == null)
            {
                return HttpNotFound();
            }
            return View(sotrudniki);
        }

        // POST: Sotrudniki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            db.Sotrudniki.Remove(sotrudniki);
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
