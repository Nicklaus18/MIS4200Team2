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
    public class UsersController : Controller
    {
        private MIS4200Team2Context db = new MIS4200Team2Context();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.businessUnit).Include(u => u.usertitles);
            return View(users.ToList());
        }

        // GET: Users/Details/5
        [Authorize]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // GET: Users/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.BusinessUnitID = new SelectList(db.BusinessUnits, "BusinessUnitID", "unit");
            ViewBag.usertitleID = new SelectList(db.userTitles, "usertitleID", "titleUser");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsersID,firstName,lastName,BusinessUnitID,usertitleID,email,phone,registeredDate")] Users users)
        {
            if (ModelState.IsValid)
            {
                Guid ID;
                Guid.TryParse(User.Identity.GetUserId(), out ID);

                users.UsersID = ID;
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessUnitID = new SelectList(db.BusinessUnits, "BusinessUnitID", "unit", users.BusinessUnitID);
            ViewBag.usertitleID = new SelectList(db.userTitles, "usertitleID", "titleUser", users.usertitleID);
            return View(users);
        }

        // GET: Users/Edit/5
        [Authorize]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessUnitID = new SelectList(db.BusinessUnits, "BusinessUnitID", "unit", users.BusinessUnitID);
            ViewBag.usertitleID = new SelectList(db.userTitles, "usertitleID", "titleUser", users.usertitleID);
            Guid ID;
            Guid.TryParse(User.Identity.GetUserId(), out ID);
            if (ID == id)
            {
                return View(users);
            }
            return View("NotAuthoritzed");
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsersID,firstName,lastName,BusinessUnitID,usertitleID,email,phone,registeredDate")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessUnitID = new SelectList(db.BusinessUnits, "BusinessUnitID", "unit", users.BusinessUnitID);
            ViewBag.usertitleID = new SelectList(db.userTitles, "usertitleID", "titleUser", users.usertitleID);
            return View(users);
        }

        // GET: Users/Delete/5
        [Authorize]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            Guid ID;
            Guid.TryParse(User.Identity.GetUserId(), out ID);
            if (ID == id)
            {
                return View(users);
            }
            return View("NotAuthoritzed");
            
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Users users = db.Users.Find(id);
            db.Users.Remove(users);
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
