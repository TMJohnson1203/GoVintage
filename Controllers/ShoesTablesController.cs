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
    public class ShoesTablesController : Controller
    {
        private VintageWardrobeEntities db = new VintageWardrobeEntities();

        // GET: ShoesTables
        public ActionResult Index()
        {
            return View(db.ShoesTables.ToList());
        }

        // GET: ShoesTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesTable shoesTable = db.ShoesTables.Find(id);
            if (shoesTable == null)
            {
                return HttpNotFound();
            }
            return View(shoesTable);
        }

        // GET: ShoesTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoesTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoesID,ShoesName,ShoesPhoto,ShoesType,ShoesColor,ShoesSeason,ShoesOccasion")] ShoesTable shoesTable)
        {
            if (ModelState.IsValid)
            {
                db.ShoesTables.Add(shoesTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoesTable);
        }

        // GET: ShoesTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesTable shoesTable = db.ShoesTables.Find(id);
            if (shoesTable == null)
            {
                return HttpNotFound();
            }
            return View(shoesTable);
        }

        // POST: ShoesTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoesID,ShoesName,ShoesPhoto,ShoesType,ShoesColor,ShoesSeason,ShoesOccasion")] ShoesTable shoesTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoesTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoesTable);
        }

        // GET: ShoesTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoesTable shoesTable = db.ShoesTables.Find(id);
            if (shoesTable == null)
            {
                return HttpNotFound();
            }
            return View(shoesTable);
        }

        // POST: ShoesTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoesTable shoesTable = db.ShoesTables.Find(id);
            db.ShoesTables.Remove(shoesTable);
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
