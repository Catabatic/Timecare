using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Timecare.Models;

namespace Timecare.Controllers
{
    public class ExerciseSchedulesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ExerciseSchedules
        public ActionResult Index()
        {
            return View(db.ExerciseSchedules.ToList());
        }

        // GET: ExerciseSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseSchedule exerciseSchedule = db.ExerciseSchedules.Find(id);
            if (exerciseSchedule == null)
            {
                return HttpNotFound();
            }
            return View(exerciseSchedule);
        }

        // GET: ExerciseSchedules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExerciseSchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PreparationTime,Name,Description,StartTime,EndTime")] ExerciseSchedule exerciseSchedule)
        {
            if (ModelState.IsValid)
            {
                db.ExerciseSchedules.Add(exerciseSchedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exerciseSchedule);
        }

        // GET: ExerciseSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseSchedule exerciseSchedule = db.ExerciseSchedules.Find(id);
            if (exerciseSchedule == null)
            {
                return HttpNotFound();
            }
            return View(exerciseSchedule);
        }

        // POST: ExerciseSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PreparationTime,Name,Description,StartTime,EndTime")] ExerciseSchedule exerciseSchedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exerciseSchedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exerciseSchedule);
        }

        // GET: ExerciseSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExerciseSchedule exerciseSchedule = db.ExerciseSchedules.Find(id);
            if (exerciseSchedule == null)
            {
                return HttpNotFound();
            }
            return View(exerciseSchedule);
        }

        // POST: ExerciseSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExerciseSchedule exerciseSchedule = db.ExerciseSchedules.Find(id);
            db.ExerciseSchedules.Remove(exerciseSchedule);
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
