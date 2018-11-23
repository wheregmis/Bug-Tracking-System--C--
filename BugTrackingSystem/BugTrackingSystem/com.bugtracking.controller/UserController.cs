using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class UserController
    {
        //method to get all users
        public void GetAllUsers() {
            string query = "select * from tbl_users";

            DataTable dt = new Database().GetData(query);
            
        }

        //method to get user details
        public DataTable GetUserDetails(String email) {

            String query = "select * from tbl_users where userEmail = '"+email+"'";
            DataTable dt = new Database().GetData(query);
            return dt;
        }

        //method to insert user
        public void InsertUser(User u)
        {
            string query = "INSERT INTO tbl_users(`firstName`, `lastName`, `userEmail`, `userPassword`, `userAddress`, `birthDate`, `gender`, `userRole`) VALUES ('" + u.Firstname + "', '" + u.Lastname + "', '" + u.Email + "', '" + u.Password + "', '" + u.Address + "', '" + u.Dob + "', '" + u.Gender + "', '" + u.Userrole + "')";
            Console.WriteLine(query);
            new Database().InsertData(query);

            MessageBox.Show("User Sucessfully Inserted");
        }

        //method to update user
        public void UpdateUser(User u) {
            string query = "UPDATE `tbl_users` SET `firstName` = '"+u.Firstname+"', `lastName` = '"+u.Lastname+"', `userRole` = '"+u.Userrole+"', `userEmail` = '"+u.Email+"', `userPassword` = '"+u.Password+"', `userAddress` = '"+u.Address+"' WHERE `userID` = '"+u.Id+"'";
            Console.WriteLine(query);
           new Database().UpdateData(query);
            MessageBox.Show("User Sucessfully Updated");
        }

        //method to delete user
        public void DeleteUser(User u) {
            string query = "Delete from tbl_users where userID = " + u.Id;
            Console.WriteLine(query);
            new Database().DeleteData(query);
            MessageBox.Show("User Sucessfully Deleted");
        }

    }
}
