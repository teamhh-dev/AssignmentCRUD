using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentCRUD.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public int Amount { get; set; }
    }
}