using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrackingSystem.com.bugtracking.dbconnection;
using BugTrackingSystem.com.bugtracking.model;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class BugController
    {
        public void InsertBug(Bug b)
        {
            //conveting image in byte[] format to save in database
            MemoryStream ms = new MemoryStream();
            b.File.Save(ms, b.File.RawFormat);
            byte[] img = ms.ToArray();

            //query to insert bug in tbl_bugs
            string query = "INSERT INTO `tbl_bugs` (`bugID`, `bugTitle`, `project`, `line`, `method`, `class`, `notes`, `sourceCode`, `screenshot`, `priority`, `reportDate`, `reportedBy`) VALUES (NULL, '"+b.BugTitle+"', '"+b.Project+"', '15', '"+b.Method+"', '"+b.BugClass+"', '"+b.Notes+ "', '" + b.Code + "',@img, '"+b.Priority+"','"+b.Date+"', '"+b.ReportedBy+"')";
            Console.WriteLine(query);

            //calling insertBug method to insert bug that is in database class
            new Database().InsertBug(query, img);
            MessageBox.Show("Bug Sucessfully Inserted");
        }

        public DataTable GetAllBugs()
        {
            //getting all bugs
            string query = "select * from tbl_bugs";

            DataTable dt = new Database().GetData(query);
            return dt;
        }

        public DataTable GetYourBugs(String email)
        {
            //getting your all bugs
            String query = "select bugStatus as 'Status', bugID as 'Bug ID', bugTitle as 'Bug Title', project as 'Project' from tbl_bugs where reportedBy = '" + email + "' order by priority";
            DataTable dt = new Database().GetData(query);
            return dt;
        }

        public DataTable GetBugDetail(int id) {
            //getting bug details
            string query = "select * from tbl_bugs where bugID = "+id;

            DataTable dt = new Database().GetData(query);
            return dt;
        }

       

        public void UpdateBugs(Bug b)
        {
            //converting image to byte[]
            MemoryStream ms = new MemoryStream();
            b.File.Save(ms, b.File.RawFormat);
            byte[] img = ms.ToArray();

            //updating bug in database
            string query = "UPDATE `tbl_bugs` SET `bugTitle` = '"+b.BugTitle+"', `project` = '"+b.Project+"', `line` = '"+b.Line+"', `method` = '"+b.Method+"', `class` = '"+b.BugClass+"', `notes` = '"+b.Notes+"', `sourceCode` = '"+b.Code+"', `priority` = '"+b.Priority+"', `screenshot` = @img WHERE `tbl_bugs`.`bugID` =" + b.BugID;
            Console.WriteLine(query);
            new Database().InsertBug(query, img);
            MessageBox.Show("Bug Sucessfully Updated");
        }

        //method to fill combobox show projects from database
        public DataTable FillCombProject() {
                 string query = "select projectName from tbl_projects";
                DataTable dt = new Database().GetData(query);
            return dt;
               
        }

        //method to delete bug from database
        public void DeleteBugs(int bugID)
        {
            String query = "delete from tbl_bugs where bugID = "+bugID;
            new Database().DeleteData(query);
            MessageBox.Show("Bug Sucessfully Deleted");
        }

        //method to update bug status in bug table
        public void UpdateStatus(int bugID)
        {
            string query = "UPDATE `tbl_bugs` SET `bugStatus` = 'Fixed' WHERE `tbl_bugs`.`bugID` =" + bugID;
            Console.WriteLine(query);
            new Database().InsertData(query);
            MessageBox.Show("Status Sucessfully Updated");
        }
    }
}
