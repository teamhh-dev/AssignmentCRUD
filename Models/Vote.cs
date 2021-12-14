using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentCRUD.Models
{
    public class Vote
    {
        public int ActivityID { get; set; }
        public string VoterName { get; set; }
        public int Radius { get; set; }
    }
}