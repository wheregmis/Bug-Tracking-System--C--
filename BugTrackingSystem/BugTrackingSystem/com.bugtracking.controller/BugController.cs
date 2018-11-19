using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            ImageConverter imgc = new ImageConverter();
            byte[] img = (byte[])imgc.ConvertTo(b.File, Type.GetType("System.Byte[]"));
            string query = "INSERT INTO `tbl_bugs` (`bugID`, `bugTitle`, `project`, `line`, `method`, `class`, `notes`, `sourceCode`, `screenshot`, `priority`, `resolved`, `comments`, `reportDate`, `reportedBy`, `resolvedBy`) VALUES (NULL, '"+b.BugTitle+"', '"+b.Project+"', '15', '"+b.Method+"', '"+b.BugClass+"', '"+b.Notes+ "', '" + b.Code + "','" +img+ "', '"+b.Priority+"', '', '', '"+b.Date+"', '"+b.ReportedBy+"', '')";
            Console.WriteLine(query);
            new Database().insertData(query);
        }

        public DataTable GetAllBugs()
        {
            string query = "select * from tbl_bugs";

            DataTable dt = new Database().getData(query);
            return dt;
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

        public DataTable FillCombProject() {
            
                string query = "select projectName from tbl_projects";

                DataTable dt = new Database().getData(query);
            return dt;
               
        }
    }
}
