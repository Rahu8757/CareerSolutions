using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CareerSolutionsLib;

namespace CareerSolutionsApp.Controllers
{
    public class Job_Seeker_RegController : Controller
    {
        private CareerSolutionsEntities db = new CareerSolutionsEntities();

        // GET: Job_Seeker_Reg
        public ActionResult Index()
        {
            return View(db.Job_Seeker.ToList());
        }

        // GET: Job_Seeker_Reg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Seeker job_Seeker = db.Job_Seeker.Find(id);
            if (job_Seeker == null)
            {
                return HttpNotFound();
            }
            return View(job_Seeker);
        }

        // GET: Job_Seeker_Reg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Job_Seeker_Reg/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "jsID,jsFullName,jsEmail,jsPassword,jsPhone,jsGender,jsDOB,jsCity,jsState,jsMaritalStatus,jsLanguagePreferred,jsResumeFileName,jsHighestQuaification,jsMajor,jsUniversity,jsInstitute,jsYearOfGraduation")] Job_Seeker job_Seeker)
        {
            if (ModelState.IsValid)
            {
                db.Job_Seeker.Add(job_Seeker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(job_Seeker);
        }

        // GET: Job_Seeker_Reg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Seeker job_Seeker = db.Job_Seeker.Find(id);
            if (job_Seeker == null)
            {
                return HttpNotFound();
            }
            return View(job_Seeker);
        }

        // POST: Job_Seeker_Reg/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "jsID,jsFullName,jsEmail,jsPassword,jsPhone,jsGender,jsDOB,jsCity,jsState,jsMaritalStatus,jsLanguagePreferred,jsResumeFileName,jsHighestQuaification,jsMajor,jsUniversity,jsInstitute,jsYearOfGraduation")] Job_Seeker job_Seeker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job_Seeker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(job_Seeker);
        }

        // GET: Job_Seeker_Reg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Seeker job_Seeker = db.Job_Seeker.Find(id);
            if (job_Seeker == null)
            {
                return HttpNotFound();
            }
            return View(job_Seeker);
        }

        // POST: Job_Seeker_Reg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job_Seeker job_Seeker = db.Job_Seeker.Find(id);
            db.Job_Seeker.Remove(job_Seeker);
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
