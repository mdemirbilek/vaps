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
    public class WHPrintoController : Controller
    {
        private VERPSEntities db = new VERPSEntities();

        // GET: WHPrinto
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHheader vwWHheader = db.vwWHheaders.Find(id.ToString());
            if (vwWHheader == null)
            {
                return HttpNotFound();
            }
            else
            {
                ViewBag.wh = vwWHheader;
                return View(db.vwWHMonthlies.Where(x => x.EmailAddress.Equals(User.Identity.Name) && x.RecYear == vwWHheader.RecYear && x.RecMonth == vwWHheader.RecMonth).ToList());
            }
        }

        public ActionResult Printo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHheader vwWHheader = db.vwWHheaders.Find(id.ToString());
            if (vwWHheader == null)
            {
                return HttpNotFound();
            }
            else
            {
                ViewBag.wh = vwWHheader;
                return View(db.vwWHMonthlies.Where(x => x.UserId.Equals(vwWHheader.UserId) && x.RecYear == vwWHheader.RecYear && x.RecMonth == vwWHheader.RecMonth).ToList());
            }
        }

        // GET: WHPrinto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            if (vwWHMonthly == null)
            {
                return HttpNotFound();
            }
            return View(vwWHMonthly);
        }

        // GET: WHPrinto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WHPrinto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Id2,WorkingDate,RecYear,RecMonth,RecDay,DayOfWeek,EntryTime,ExitTime,AssignedWorkingHour,AcceptedOTeHrs,AcceptedOTMin,IsOTAccepted,HourDiff,MinuteDiff,TotalHours,TotalMinutes,Exception,Note,UserStory,EmailAddress,FullName,UserId")] vwWHMonthly vwWHMonthly)
        {
            if (ModelState.IsValid)
            {
                db.vwWHMonthlies.Add(vwWHMonthly);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vwWHMonthly);
        }

        // GET: WHPrinto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            if (vwWHMonthly == null)
            {
                return HttpNotFound();
            }
            return View(vwWHMonthly);
        }

        // POST: WHPrinto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id2,WorkingDate,RecYear,RecMonth,RecDay,DayOfWeek,EntryTime,ExitTime,AssignedWorkingHour,AcceptedOTeHrs,AcceptedOTMin,IsOTAccepted,HourDiff,MinuteDiff,TotalHours,TotalMinutes,Exception,Note,UserStory,EmailAddress,FullName,UserId")] vwWHMonthly vwWHMonthly)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vwWHMonthly).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vwWHMonthly);
        }

        // GET: WHPrinto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            if (vwWHMonthly == null)
            {
                return HttpNotFound();
            }
            return View(vwWHMonthly);
        }

        // POST: WHPrinto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            db.vwWHMonthlies.Remove(vwWHMonthly);
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
