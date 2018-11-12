using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class UserController
    {

        public void GetAllUsers() {
            string query = "select * from tbl_users";

            DataTable dt = new Database().getData(query);
            
        }

        public DataTable GetUserDetails(String username) {

            String query = "select * from tbl_users where username = '"+username+"'";
            DataTable dt = new Database().getData(query);
            return dt;
        }

        public void InsertUser(User u)
        {
            string query = "INSERT INTO tbl_users(`userName`, `firstName`, `lastName`, `userEmail`, `userPassword`, `userAddress`, `birthDate`, `gender`, `userRole`, `userType`) VALUES ('" + u.Username + "', '" + u.FirstName + "', '" + u.LastName + "', '" + u.Email + "', '" + u.Password + "', '" + u.Address + "', '" + u.Dob + "', '" + u.Gender + "', '" + u.Userrole + "', 2)";
            Console.WriteLine(query);
            new Database().insertData(query);

        }

        public void UpdateUser() {

        }

    }
}
