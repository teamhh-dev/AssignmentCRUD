using AssignmentCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentCRUD.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult All()
        {
            //List<Contact> contact = new List<Contact>() { new Contact(){ ID = 1, Email = "h@.com", Name = "Hamza", ActiveSince = DateTime.Now.AddDays(-5), PhoneNumber = "03124546453" }  };

            return View(new DataContext().Contacts.ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {

            return View(new DataContext().Contacts.Find(id));
        }

        // GET: Contact/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DataContext context = new DataContext();
                var contact = context.Contacts.Add(new Contact() { Name = collection["Name"], Email = collection["Email"], PhoneNumber = collection["PhoneNumber"], ActiveSince = Convert.ToDateTime(collection["ActiveSince"]) });
                //contact.Name = collection["Name"];
                //contact.PhoneNumber = collection["Email"];
                //contact.PhoneNumber = collection["PhoneNumber"];
                //contact.ActiveSince = collection["ActiveSince"];
                context.SaveChanges();

                // TODO: Add insert logic here
                return RedirectToAction("All");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View(new DataContext().Contacts.Find(id));
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                DataContext context = new DataContext();
                var toUpdate = context.Contacts.Find(id);
                toUpdate.Name = collection["Name"];
                toUpdate.PhoneNumber = collection["PhoneNumber"];
                toUpdate.Email = collection["Email"];
                toUpdate.ActiveSince = Convert.ToDateTime(collection["ActiveSince"]);
                context.SaveChanges();

                return RedirectToAction("All");
            }
            catch
            {
                return View("All");
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View(new DataContext().Contacts.Find(id));
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                DataContext context = new DataContext();
                context.Contacts.Remove(context.Contacts.Find(id));
                // TODO: Add delete logic here
                context.SaveChanges();
                return RedirectToAction("All");
            }
            catch
            {
                return View();
            }
        }
    }
}
