using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
            MemoryStream ms = new MemoryStream();
            b.File.Save(ms, b.File.RawFormat);
            byte[] img = ms.ToArray();
            string query = "INSERT INTO `tbl_bugs` (`bugID`, `bugTitle`, `project`, `line`, `method`, `class`, `notes`, `sourceCode`, `screenshot`, `priority`, `reportDate`, `reportedBy`) VALUES (NULL, '"+b.BugTitle+"', '"+b.Project+"', '15', '"+b.Method+"', '"+b.BugClass+"', '"+b.Notes+ "', '" + b.Code + "',@img, '"+b.Priority+"','"+b.Date+"', '"+b.ReportedBy+"')";
            Console.WriteLine(query);
            new Database().insertBug(query, img);
        }

        public DataTable GetAllBugs()
        {
            string query = "select * from tbl_bugs";

            DataTable dt = new Database().getData(query);
            return dt;
        }

        public DataTable GetYourBugs(String email)
        {

            String query = "select bugStatus as 'Status', bugID as 'Bug ID', bugTitle as 'Bug Title', project as 'Project' from tbl_bugs where reportedBy = '" + email + "' order by priority";
            DataTable dt = new Database().getData(query);
            return dt;
        }

        public DataTable GetBugDetail(int id) {
            string query = "select * from tbl_bugs where bugID = "+id;

            DataTable dt = new Database().getData(query);
            return dt;
        }

       

        public void UpdateBugs(Bug b)
        {
            MemoryStream ms = new MemoryStream();
            b.File.Save(ms, b.File.RawFormat);
            byte[] img = ms.ToArray();
            string query = "UPDATE `tbl_bugs` SET `bugTitle` = '"+b.BugTitle+"', `project` = '"+b.Project+"', `line` = '"+b.Line+"', `method` = '"+b.Method+"', `class` = '"+b.BugClass+"', `notes` = '"+b.Notes+"', `sourceCode` = '"+b.Code+"', `priority` = '"+b.Priority+"', `screenshot` = @img WHERE `tbl_bugs`.`bugID` =" + b.BugID;
            Console.WriteLine(query);
            new Database().insertBug(query, img);
        }

        public DataTable FillCombProject() {
            
                string query = "select projectName from tbl_projects";

                DataTable dt = new Database().getData(query);
            return dt;
               
        }

        public void DeleteBugs(int bugID)
        {
            String query = "delete from tbl_bugs where bugID = "+bugID;
            new Database().DeleteData(query);
        }
    }
}
