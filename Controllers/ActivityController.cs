using AssignmentCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentCRUD.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult Index()
        {
            List<Activity> activities = new List<Activity>() { new Activity() { ID=1,Name="Cinema",Duration="3 hours",Amount=50}, new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 },new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 } };

            return View(activities);
        }
        public ActionResult Vote(int id)
        {
            //List<Activity> activities = new List<Activity>() { new Activity() { ID=1,Name="Cinema",Duration="3 hours",Amount=50}, new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 },new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 } };

            return View();
        }
    }
}