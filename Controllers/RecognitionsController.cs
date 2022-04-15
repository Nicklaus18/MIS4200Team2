using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MIS4200Team2.DAL;
using MIS4200Team2.Models;

namespace MIS4200Team2.Controllers
{
    public class RecognitionsController : Controller
    {
        private MIS4200Team2Context db = new MIS4200Team2Context();

        // GET: Recognitions
        public ActionResult Index()
        {
            var recognitions = db.Recognitions.Include(r => r.CoreValues).Include(r => r.Users);
            return View(recognitions.ToList());
        }

        // GET: Recognitions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // GET: Recognitions/Create
        public ActionResult Create()
        {
            ViewBag.CoreValuesID = new SelectList(db.CoreValues, "CoreValuesID", "CoreValue");
            //ViewBag.UsersID = new SelectList(db.Users, "UsersID", "firstName");
            string usersID = User.Identity.GetUserId();
            SelectList users = new SelectList(db.Users, "UsersID", "fullName");
            users = new SelectList(users.Where(x => x.Value != usersID).ToList(), "Value", "Text");
            ViewBag.UsersID = users;
            return View();
        }

        // POST: Recognitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecognitionID,UsersID,CoreValuesID,descriptionOfValue")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                db.Recognitions.Add(recognition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoreValuesID = new SelectList(db.CoreValues, "CoreValuesID", "CoreValue", recognition.CoreValuesID);
            ViewBag.UsersID = new SelectList(db.Users, "UsersID", "firstName", recognition.UsersID);
            return View(recognition);
        }

        // GET: Recognitions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoreValuesID = new SelectList(db.CoreValues, "CoreValuesID", "CoreValue", recognition.CoreValuesID);
            ViewBag.UsersID = new SelectList(db.Users, "UsersID", "firstName", recognition.UsersID);
            return View(recognition);
        }

        // POST: Recognitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecognitionID,UsersID,CoreValuesID,descriptionOfValue")] Recognition recognition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recognition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoreValuesID = new SelectList(db.CoreValues, "CoreValuesID", "CoreValue", recognition.CoreValuesID);
            ViewBag.UsersID = new SelectList(db.Users, "UsersID", "firstName", recognition.UsersID);
            return View(recognition);
        }

        // GET: Recognitions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recognition recognition = db.Recognitions.Find(id);
            if (recognition == null)
            {
                return HttpNotFound();
            }
            return View(recognition);
        }

        // POST: Recognitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recognition recognition = db.Recognitions.Find(id);
            db.Recognitions.Remove(recognition);
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
