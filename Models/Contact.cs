using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentCRUD.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Active Since")]
        public DateTime ActiveSince { get; set; }
    }
}