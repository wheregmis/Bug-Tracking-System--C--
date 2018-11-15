using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class BugController
    {
        public void InsertBug(Bug b)
        {
          //  string query = "INSERT INTO tbl_users(`userName`, `firstName`, `lastName`, `userEmail`, `userPassword`, `userAddress`, `birthDate`, `gender`, `userRole`, `userType`) VALUES ('" + u.Username + "', '" + u.FirstName + "', '" + u.LastName + "', '" + u.Email + "', '" + u.Password + "', '" + u.Address + "', '" + u.Dob + "', '" + u.Gender + "', '" + u.Userrole + "', 2)";
         //   Console.WriteLine(query);
         //   new Database().insertData(query);
        }

        public void GetAllBugs()
        {
            string query = "select * from tbl_users";

            DataTable dt = new Database().getData(query);

        }

        public DataTable GetYourBugs(String username)
        {

            String query = "select * from tbl_users where username = '" + username + "'";
            DataTable dt = new Database().getData(query);
            return dt;
        }

       

        public void UpdateBugs(Bug b)
        {
           // string query = "UPDATE `tbl_users` SET `firstName` = '" + u.FirstName + "', `lastName` = '" + u.LastName + "', `userRole` = '" + u.Userrole + "', `userEmail` = '" + u.Email + "', `userPassword` = '" + u.Password + "', `userAddress` = '" + u.Address + "' WHERE `userName` = '" + u.Username + "'";
          //  Console.WriteLine(query);
          //  new Database().updateData(query);
        }
    }
}
