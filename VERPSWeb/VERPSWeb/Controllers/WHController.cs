using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VERPSWeb;

namespace VERPSWeb.Controllers
{
    public class WHController : Controller
    {
        private VERPSEntities db = new VERPSEntities();

        // GET: WH
        public ActionResult Index()
        {
            return View(db.vwWHheaders.Where(x => x.EmailAddress.Equals(User.Identity.Name)).ToList());
        }

        // GET: WH/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHheader vwWHheader = db.vwWHheaders.Find(id);
            if (vwWHheader == null)
            {
                return HttpNotFound();
            }
            return View(vwWHheader);
        }

        // GET: WH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WH/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,EmailAddress,RecYear,RecMonth,AWH,TotalWorkingTime,TimeDiff,TotalOvertime,UserId")] vwWHheader vwWHheader)
        {
            if (ModelState.IsValid)
            {
                db.vwWHheaders.Add(vwWHheader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vwWHheader);
        }

        // GET: WH/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHheader vwWHheader = db.vwWHheaders.Find(id);
            if (vwWHheader == null)
            {
                return HttpNotFound();
            }
            return View(vwWHheader);
        }

        // POST: WH/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,EmailAddress,RecYear,RecMonth,AWH,TotalWorkingTime,TimeDiff,TotalOvertime,UserId")] vwWHheader vwWHheader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vwWHheader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vwWHheader);
        }

        // GET: WH/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHheader vwWHheader = db.vwWHheaders.Find(id);
            if (vwWHheader == null)
            {
                return HttpNotFound();
            }
            return View(vwWHheader);
        }

        // POST: WH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vwWHheader vwWHheader = db.vwWHheaders.Find(id);
            db.vwWHheaders.Remove(vwWHheader);
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
