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
    public class SwimTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: SwimTables
        public ActionResult Index()
        {
            return View(db.SwimTables.ToList());
        }

        // GET: SwimTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SwimTable swimTable = db.SwimTables.Find(id);
            if (swimTable == null)
            {
                return HttpNotFound();
            }
            return View(swimTable);
        }

        // GET: SwimTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SwimTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SwimTableID,SwimName,SwimPhoto,SwimType,SwimColor,SwimSeason,SwimOccasion")] SwimTable swimTable)
        {
            if (ModelState.IsValid)
            {
                db.SwimTables.Add(swimTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(swimTable);
        }

        // GET: SwimTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SwimTable swimTable = db.SwimTables.Find(id);
            if (swimTable == null)
            {
                return HttpNotFound();
            }
            return View(swimTable);
        }

        // POST: SwimTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SwimTableID,SwimName,SwimPhoto,SwimType,SwimColor,SwimSeason,SwimOccasion")] SwimTable swimTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(swimTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(swimTable);
        }

        // GET: SwimTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SwimTable swimTable = db.SwimTables.Find(id);
            if (swimTable == null)
            {
                return HttpNotFound();
            }
            return View(swimTable);
        }

        // POST: SwimTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SwimTable swimTable = db.SwimTables.Find(id);
            db.SwimTables.Remove(swimTable);
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
