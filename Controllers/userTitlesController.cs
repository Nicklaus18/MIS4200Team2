using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIS4200Team2.DAL;
using MIS4200Team2.Models;

namespace MIS4200Team2.Controllers
{
    public class userTitlesController : Controller
    {
        private MIS4200Team2Context db = new MIS4200Team2Context();

        // GET: userTitles
        public ActionResult Index()
        {
            return View(db.userTitles.ToList());
        }

        // GET: userTitles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userTitle userTitle = db.userTitles.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // GET: userTitles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: userTitles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usertitleID,titleUser")] userTitle userTitle)
        {
            if (ModelState.IsValid)
            {
                db.userTitles.Add(userTitle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userTitle);
        }

        // GET: userTitles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userTitle userTitle = db.userTitles.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // POST: userTitles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "usertitleID,titleUser")] userTitle userTitle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userTitle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userTitle);
        }

        // GET: userTitles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userTitle userTitle = db.userTitles.Find(id);
            if (userTitle == null)
            {
                return HttpNotFound();
            }
            return View(userTitle);
        }

        // POST: userTitles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            userTitle userTitle = db.userTitles.Find(id);
            db.userTitles.Remove(userTitle);
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
