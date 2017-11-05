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
    public class DressesTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: DressesTables
        public ActionResult Index()
        {
            return View(db.DressesTables.ToList());
        }

        // GET: DressesTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DressesTable dressesTable = db.DressesTables.Find(id);
            if (dressesTable == null)
            {
                return HttpNotFound();
            }
            return View(dressesTable);
        }

        // GET: DressesTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DressesTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DressesID,DressesName,DressesPhoto,DressesType,DressesColor,DressesSeason,DressesOccasion")] DressesTable dressesTable)
        {
            if (ModelState.IsValid)
            {
                db.DressesTables.Add(dressesTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dressesTable);
        }

        // GET: DressesTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DressesTable dressesTable = db.DressesTables.Find(id);
            if (dressesTable == null)
            {
                return HttpNotFound();
            }
            return View(dressesTable);
        }

        // POST: DressesTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DressesID,DressesName,DressesPhoto,DressesType,DressesColor,DressesSeason,DressesOccasion")] DressesTable dressesTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dressesTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dressesTable);
        }

        // GET: DressesTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DressesTable dressesTable = db.DressesTables.Find(id);
            if (dressesTable == null)
            {
                return HttpNotFound();
            }
            return View(dressesTable);
        }

        // POST: DressesTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DressesTable dressesTable = db.DressesTables.Find(id);
            db.DressesTables.Remove(dressesTable);
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
