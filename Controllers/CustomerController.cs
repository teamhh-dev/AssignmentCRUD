using AssignmentCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentCRUD.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private DataContext _db=new DataContext();
        List<string> list = new List<string>()
            {
                "Pakistan",
                "UAE",
                "Saudia"
            };
        public ActionResult Index()
        {
            
            return View(_db.Customers.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(_db.Customers.FirstOrDefault(i => i.Id == id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {

            
            SelectList countryList = new SelectList(list);

            ViewBag.Countries = list;
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                _db.Customers.Add(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Countries = list;
            ViewBag.selectCountry = _db.Customers.FirstOrDefault(i => i.Id == id).Country;

            return View(_db.Customers.FirstOrDefault(i => i.Id == id));
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                var old=_db.Customers.FirstOrDefault(i => i.Id == id);
                old.Name = customer.Name;
                old.Address = customer.Address;
                old.Country = customer.Country;
                old.City = customer.City;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_db.Customers.FirstOrDefault(i => i.Id == id));
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                // TODO: Add delete logic here
                var toDelete = _db.Customers.FirstOrDefault(i => i.Id == id);
                _db.Customers.Remove(toDelete);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
