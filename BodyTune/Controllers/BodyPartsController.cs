using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BodyTune.Models;

namespace BodyTune.Controllers
{
    public class BodyPartsController : Controller
    {
        private DataModel db = new DataModel();

        // GET: BodyParts
        public ActionResult Index()
        {
            return View(db.BodyParts.ToList());
        }

        // GET: BodyParts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyPart bodyPart = db.BodyParts.Find(id);
            if (bodyPart == null)
            {
                return HttpNotFound();
            }
            return View(bodyPart);
        }

        // GET: BodyParts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BodyParts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BodyPartId,BodyPartName")] BodyPart bodyPart)
        {
            if (ModelState.IsValid)
            {
                db.BodyParts.Add(bodyPart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bodyPart);
        }

        // GET: BodyParts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyPart bodyPart = db.BodyParts.Find(id);
            if (bodyPart == null)
            {
                return HttpNotFound();
            }
            return View(bodyPart);
        }

        // POST: BodyParts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BodyPartId,BodyPartName")] BodyPart bodyPart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bodyPart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bodyPart);
        }

        // GET: BodyParts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyPart bodyPart = db.BodyParts.Find(id);
            if (bodyPart == null)
            {
                return HttpNotFound();
            }
            return View(bodyPart);
        }

        // POST: BodyParts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BodyPart bodyPart = db.BodyParts.Find(id);
            db.BodyParts.Remove(bodyPart);
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