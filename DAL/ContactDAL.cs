using AssignmentCRUD.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace AssignmentCRUD.DAL
{
    public class ContactDAL
    {
        public MySqlConnection connection { get; set; }

        
        public ContactDAL()
        {
            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            connection = new MySqlConnection(cs);
            

        }

        public List<Contact> getAllContacts()
        {

            List<Contact> contactList = new List<Contact>() { new Contact() { ID = 1, Name = "Hamza", Email = "@.com", ActiveSince = DateTime.Now, PhoneNumber = "0312" } };
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from country", connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
            }
            connection.Close();
            return contactList;
        }

        public bool createContact(FormCollection collection)
        {
            try
            {
                //connection.

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}