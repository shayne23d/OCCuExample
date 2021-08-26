using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OCCUEmployees.DAL;
using OCCUEmployees.Models;

namespace OCCUEmployees.Controllers
{
    public class ErrorController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        // GET: Error
        public ActionResult Index()
        {
            return View(db.Errors.ToList());
        }

        // GET: Error/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Errors errors = db.Errors.Find(id);
            if (errors == null)
            {
                return HttpNotFound();
            }
            return View(errors);
        }

        // GET: Error/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Error/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Error")] Errors errors)
        {
            if (ModelState.IsValid)
            {
                db.Errors.Add(errors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(errors);
        }

        // GET: Error/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Errors errors = db.Errors.Find(id);
            if (errors == null)
            {
                return HttpNotFound();
            }
            return View(errors);
        }

        // POST: Error/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Error")] Errors errors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(errors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(errors);
        }

        // GET: Error/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Errors errors = db.Errors.Find(id);
            if (errors == null)
            {
                return HttpNotFound();
            }
            return View(errors);
        }

        // POST: Error/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Errors errors = db.Errors.Find(id);
            db.Errors.Remove(errors);
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
