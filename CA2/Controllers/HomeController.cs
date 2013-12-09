using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA2.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var q = db.Orders;
            return View(q);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        public PartialViewResult EmployeeDetails (int id)
        {
            //Order o = db.Orders.Find(id);

            var details = from ed in db.Employees
                          where ed.EmployeeID == id
                          select ed;

            ViewBag.reportFname = (from r in db.Employees
                                   //join o in db.Orders on r.ReportsTo equals o.EmployeeID
                                   where r.ReportsTo == id
                                   select r.FirstName).FirstOrDefault().Distinct();

            //ViewBag.reportLname = (from o in db.Orders
            //                       join b in db.Employees on o.EmployeeID equals b.ReportsTo
            //                       where o.EmployeeID == id
            //                       select b.LastName).FirstOrDefault();

            return PartialView("_EmployeeDetails", details);
        }

        public PartialViewResult ShowOrders(int id)
        {
            var orders = from o in db.Orders
                         where o.EmployeeID == id
                         select o;
            return PartialView("_EmployeesOrdersTaken", orders);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home4/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            

            ViewBag.Shipper = (from s in db.Shippers
                               select new
                               {
                                   cName = s.CompanyName,
                                   sID = s.ShipperID
                               }).Distinct().ToList();

            ViewBag.Employee = (from e in db.Employees
                                select new
                                {
                                    lName = e.LastName, //string.Format("{0} {1}",e.FirstName, e.LastName),
                                    eID = e.EmployeeID
                                }).Distinct().ToList();
            
            //ViewBag.ArtistId = new SelectList(db.Customers, "ArtistId", "Name", o.CustomerID);

            return (o == null) ? View() : View("_Edit", o);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Order o) //int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(o).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(o);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
