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
    public class BottomsTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: BottomsTables
        public ActionResult Index()
        {
            return View(db.BottomsTables.ToList());
        }

        // GET: BottomsTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsTable bottomsTable = db.BottomsTables.Find(id);
            if (bottomsTable == null)
            {
                return HttpNotFound();
            }
            return View(bottomsTable);
        }

        // GET: BottomsTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottomsTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsID,BottomsName,BottomsPhoto,BottomsType,BottomsColor,BottomsSeason,BottomsOccasion")] BottomsTable bottomsTable)
        {
            if (ModelState.IsValid)
            {
                db.BottomsTables.Add(bottomsTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottomsTable);
        }

        // GET: BottomsTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsTable bottomsTable = db.BottomsTables.Find(id);
            if (bottomsTable == null)
            {
                return HttpNotFound();
            }
            return View(bottomsTable);
        }

        // POST: BottomsTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsID,BottomsName,BottomsPhoto,BottomsType,BottomsColor,BottomsSeason,BottomsOccasion")] BottomsTable bottomsTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottomsTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottomsTable);
        }

        // GET: BottomsTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsTable bottomsTable = db.BottomsTables.Find(id);
            if (bottomsTable == null)
            {
                return HttpNotFound();
            }
            return View(bottomsTable);
        }

        // POST: BottomsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BottomsTable bottomsTable = db.BottomsTables.Find(id);
            db.BottomsTables.Remove(bottomsTable);
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
