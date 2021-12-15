using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AssignmentCRUD.Models
{
    public class Vote
    {
        public int ID { get; set; }
        public int ActivityID { get; set; }

        [DisplayName("Voter Name")]
        public string VoterName { get; set; }
        public int Radius { get; set; }
    }
}