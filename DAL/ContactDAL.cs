using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentCRUD.DAL
{
    public class ContactDAL
    {
        public MySqlConnection connection { get; set; }

        
        public ContactDAL()
        {
            connection = new MySqlConnection();

        }
    }
}