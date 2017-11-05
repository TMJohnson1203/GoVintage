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
    public class AccessTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: AccessTables
        public ActionResult Index()
        {
            return View(db.AccessTables.ToList());
        }

        // GET: AccessTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessTable accessTable = db.AccessTables.Find(id);
            if (accessTable == null)
            {
                return HttpNotFound();
            }
            return View(accessTable);
        }

        // GET: AccessTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessID,AccessName,AccessPhoto,AccessType,AccessColor,AccessSeason,AccessOccasion")] AccessTable accessTable)
        {
            if (ModelState.IsValid)
            {
                db.AccessTables.Add(accessTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessTable);
        }

        // GET: AccessTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessTable accessTable = db.AccessTables.Find(id);
            if (accessTable == null)
            {
                return HttpNotFound();
            }
            return View(accessTable);
        }

        // POST: AccessTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessID,AccessName,AccessPhoto,AccessType,AccessColor,AccessSeason,AccessOccasion")] AccessTable accessTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessTable);
        }

        // GET: AccessTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessTable accessTable = db.AccessTables.Find(id);
            if (accessTable == null)
            {
                return HttpNotFound();
            }
            return View(accessTable);
        }

        // POST: AccessTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccessTable accessTable = db.AccessTables.Find(id);
            db.AccessTables.Remove(accessTable);
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
