using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BarrieXPress.Models;

namespace BarrieXPress.Controllers
{
    public class FaresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Fares
        public ActionResult Index()
        {
            return View(db.Fares.ToList());
        }

        // GET: Fares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fare fare = db.Fares.Find(id);
            if (fare == null)
            {
                return HttpNotFound();
            }
            return View(fare);
        }

        // GET: Fares/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "FareId,Name,FareInfo")] Fare fare)
        {
            if (ModelState.IsValid)
            {
                db.Fares.Add(fare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fare);
        }

        // GET: Fares/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fare fare = db.Fares.Find(id);
            if (fare == null)
            {
                return HttpNotFound();
            }
            return View(fare);
        }

        // POST: Fares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "FareId,Name,FareInfo")] Fare fare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fare);
        }

        // GET: Fares/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fare fare = db.Fares.Find(id);
            if (fare == null)
            {
                return HttpNotFound();
            }
            return View(fare);
        }

        // POST: Fares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fare fare = db.Fares.Find(id);
            db.Fares.Remove(fare);
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
