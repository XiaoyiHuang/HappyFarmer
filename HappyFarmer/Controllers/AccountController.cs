using System;
using System.Web.Mvc;
using HappyFarmer.Models;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;

namespace HappyFarmer.Controllers
{
   
    public class AccountController : Controller
    {
        private const string SchemaName = "happyschema";
        private const string UserTableName = "user";
        
        #region REGISTER
        
        public ActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                string Username = model.Username;
                string Email = model.Email;
                string Password = model.Password;
                
                /* Hash password */

                /* Get database connection string */
                string connStr = GetConnectionString();
                
                /* Formulate SQL command */
                string query = "INSERT INTO " + SchemaName
                                              + "."
                                              + UserTableName
                                              + " (username, email, password)"
                                              + " VALUES "
                                              + "(@Username, "
                                              + "@Email, "
                                              + "@Password)";
                
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("Username", Username);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Password", Password);
                    
                    InsertDataToDatabase(connStr, cmd);
                }
                
                // Clean up
                ModelState.Clear();
                ViewBag.Message = "Register Succeed!";
            }

            return View(model);
        }
        
        #endregion
        
        #region LOGIN
        
        public ActionResult Login()
        {
            return PartialView();
        }  
        
        #endregion
        
        #region HELPER FUNCTION
        
        /*
         * Get connection string for database connection
         */
        public string GetConnectionString()
        {
            ConnectionStringSettings defaultConn = ConfigurationManager.
                ConnectionStrings["DefaultConnection"];
            
            if (defaultConn == null || string.IsNullOrEmpty(defaultConn.ConnectionString))
            {
                throw new Exception("Fatal error: missing connecting string in web.config file");
            }
            
            return defaultConn.ConnectionString;
        }
        
        /*
         * Execute insertion to database
         */
        public void InsertDataToDatabase(string connStr, NpgsqlCommand cmd)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }
        
        #endregion
    }
}