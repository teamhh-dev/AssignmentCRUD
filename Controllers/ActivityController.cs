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
            //List<Activity> activities = new List<Activity>() 
            //{ new Activity() { ID=1,Name="Cinema",Duration="3 hours",Amount=50}, 
            //    new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 },
            //    new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 } };
            DataContext _db = new DataContext();
            //_db.Activities.Add(new Activity() { ID = 1, Name = "Cinema", Duration = "3 hours", Amount = 50 });
            //_db.Activities.Add(new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 });
            //_db.Activities.Add(new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 });
            //_db.SaveChanges();
            return View(_db.Activities.ToList());
        }
        public ActionResult Vote(int id)
        {
            DataContext _db = new DataContext();

            //List<Activity> activities = new List<Activity>() { new Activity() { ID=1,Name="Cinema",Duration="3 hours",Amount=50}, new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 },new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 } };
            ViewBag.name = _db.Activities.Find(id).Name;
            return View();
        }

        [HttpPost]
        public ActionResult Vote(int id, FormCollection collection)
        {

            try
            {
                DataContext _db = new DataContext();
                _db.Votes.Add(new Vote() { ActivityID = id, Radius = Convert.ToInt32(collection["Radius"]), VoterName = collection["VoterName"] });
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View();
            }
            //List<Activity> activities = new List<Activity>() { new Activity() { ID=1,Name="Cinema",Duration="3 hours",Amount=50}, new Activity() { ID = 2, Name = "Hiking", Duration = "5 hours", Amount = 100 },new Activity() { ID = 3, Name = "Chalet", Duration = "4 hours", Amount = 400 } };
            //Console.WriteLine(collection[""]);
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Consult()
        {
            
            DataContext _db = new DataContext();
            
            var votingResult = from v in _db.Votes join a in _db.Activities on v.ActivityID equals a.ID select new { a.Name, a.ID, v.ActivityID } into x group x by new { x.Name,x.ActivityID} into g select new { ActivityName = g.Key.Name,VoteCount=g.Select(y=>y.ActivityID).Count() } into res orderby(res.VoteCount) descending select new Result(){ Name=res.ActivityName,Count=res.VoteCount};
            
            return View(votingResult);
        }
    }


}