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
    public class WHMonthliesController : Controller
    {
        private VERPSEntities db = new VERPSEntities();

        // GET: WHMonthlies
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

        // GET: WHMonthlies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            vwWHMonthly vwWHMonthly = (vwWHMonthly)db.vwWHMonthlies.Where(x => x.EmailAddress.Equals(User.Identity.Name) && x.Id == id).First();

            if (vwWHMonthly == null)
            {
                return HttpNotFound();
            }
            return View(vwWHMonthly);
        }

        // GET: WHMonthlies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WHMonthlies/Create
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

        // GET: WHMonthlies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //vwWHMonthly vwWHMonthly = db.vwWHMonthlies.Find(id);
            vwWHMonthly vwWHMonthly = (vwWHMonthly)db.vwWHMonthlies.Where(x => x.EmailAddress.Equals(User.Identity.Name) && x.Id == id).First();

            if (vwWHMonthly == null)
            {
                return HttpNotFound();
            }
            return View(vwWHMonthly);
        }

        // POST: WHMonthlies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Id2,WorkingDate,RecYear,RecMonth,RecDay,DayOfWeek,EntryTime,ExitTime,AssignedWorkingHour,AcceptedOTeHrs,AcceptedOTMin,IsOTAccepted,HourDiff,MinuteDiff,TotalHours,TotalMinutes,Exception,Note,UserStory,EmailAddress,FullName,UserId")] vwWHMonthly vwWHMonthly)
        {
            int myId = 0;

            if (ModelState.IsValid)
            {

                int whId = vwWHMonthly.Id;
                string whId2 = vwWHMonthly.Id2;
                string whUS = vwWHMonthly.UserStory;

                //db.Entry(vwWHMonthly).State = EntityState.Modified;

                hrWorkingHour hrWH = db.hrWorkingHours.Find(whId);
                if (hrWH != null)
                {
                    hrWH.UserStory = whUS;
                }

                db.SaveChanges();
                //return RedirectToAction("Back to the list..", "../whmonthlies/index", new { id = whId2 });

            }

            vwWHMonthly monthly = db.vwWHMonthlies.Find(vwWHMonthly.Id);

            //Response.Write("<script>function myFunction() { alert('I am an alert box!'); } </ script >");

            TempData["msg"] = "<script>alert('Succesfully saved!');</script>";

            return View(monthly);
        }

        // GET: WHMonthlies/Delete/5
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

        // POST: WHMonthlies/Delete/5
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
