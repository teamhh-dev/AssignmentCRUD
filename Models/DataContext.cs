﻿using MySql.Data.MySqlClient;
using System.Data.Entity;

namespace AssignmentCRUD.Models
{
    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection") //This 'DefaultConnection' should be equal to the connection string name on Web.config.
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }
        public DbSet<Contact> Contacts { get; set; }

    }
}