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
    public class DolzhnostiController : Controller
    {
        private OooPs14_dbEntities2 db = new OooPs14_dbEntities2();

        // GET: Dolzhnosti
        public ActionResult Index()
        {
            return View(db.Dolzhnosti.ToList());
        }

        // GET: Dolzhnosti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dolzhnosti dolzhnosti = db.Dolzhnosti.Find(id);
            if (dolzhnosti == null)
            {
                return HttpNotFound();
            }
            return View(dolzhnosti);
        }

        // GET: Dolzhnosti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dolzhnosti/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_dolzhn,name_dolzhn")] Dolzhnosti dolzhnosti)
        {
            if (ModelState.IsValid)
            {
                db.Dolzhnosti.Add(dolzhnosti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dolzhnosti);
        }

        // GET: Dolzhnosti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dolzhnosti dolzhnosti = db.Dolzhnosti.Find(id);
            if (dolzhnosti == null)
            {
                return HttpNotFound();
            }
            return View(dolzhnosti);
        }

        // POST: Dolzhnosti/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_dolzhn,name_dolzhn")] Dolzhnosti dolzhnosti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dolzhnosti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dolzhnosti);
        }

        // GET: Dolzhnosti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dolzhnosti dolzhnosti = db.Dolzhnosti.Find(id);
            if (dolzhnosti == null)
            {
                return HttpNotFound();
            }
            return View(dolzhnosti);
        }

        // POST: Dolzhnosti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dolzhnosti dolzhnosti = db.Dolzhnosti.Find(id);
            db.Dolzhnosti.Remove(dolzhnosti);
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
