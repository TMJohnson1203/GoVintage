using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoVintage.Models;

namespace GoVintage.Controllers
{
    public class TopsTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: TopsTables
        public ActionResult Index()
        {
            return View(db.TopsTables.ToList());
        }

        // GET: TopsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopsTable topsTable = db.TopsTables.Find(id);
            if (topsTable == null)
            {
                return HttpNotFound();
            }
            return View(topsTable);
        }

        // GET: TopsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopsID,TopsName,TopsPhoto,TopsType,TopsColor,TopsSeason,TopsOccasion")] TopsTable topsTable)
        {
            if (ModelState.IsValid)
            {
                db.TopsTables.Add(topsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(topsTable);
        }

        // GET: TopsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopsTable topsTable = db.TopsTables.Find(id);
            if (topsTable == null)
            {
                return HttpNotFound();
            }
            return View(topsTable);
        }

        // POST: TopsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopsID,TopsName,TopsPhoto,TopsType,TopsColor,TopsSeason,TopsOccasion")] TopsTable topsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topsTable);
        }

        // GET: TopsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopsTable topsTable = db.TopsTables.Find(id);
            if (topsTable == null)
            {
                return HttpNotFound();
            }
            return View(topsTable);
        }

        // POST: TopsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TopsTable topsTable = db.TopsTables.Find(id);
            db.TopsTables.Remove(topsTable);
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
