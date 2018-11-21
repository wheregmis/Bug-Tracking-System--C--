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

        public DataTable GetUserDetails(String email) {

            String query = "select * from tbl_users where userEmail = '"+email+"'";
            DataTable dt = new Database().getData(query);
            return dt;
        }

        public void InsertUser(User u)
        {
            string query = "INSERT INTO tbl_users(`firstName`, `lastName`, `userEmail`, `userPassword`, `userAddress`, `birthDate`, `gender`, `userRole`) VALUES ('" + u.Firstname + "', '" + u.Lastname + "', '" + u.Email + "', '" + u.Password + "', '" + u.Address + "', '" + u.Dob + "', '" + u.Gender + "', '" + u.Userrole + "')";
            Console.WriteLine(query);
            new Database().insertData(query);

        }

        public void UpdateUser(User u) {
            string query = "UPDATE `tbl_users` SET `firstName` = '"+u.Firstname+"', `lastName` = '"+u.Lastname+"', `userRole` = '"+u.Userrole+"', `userEmail` = '"+u.Email+"', `userPassword` = '"+u.Password+"', `userAddress` = '"+u.Address+"' WHERE `userID` = '"+u.Id+"'";
            Console.WriteLine(query);
           new Database().updateData(query);
        }

        public void DeleteUser(User u) {
            string query = "Delete from tbl_users where userID = " + u.Id;
            Console.WriteLine(query);
            new Database().DeleteData(query);
        }

    }
}
