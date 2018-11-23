using BugTrackingSystem.com.bugtracking.dbconnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.com.bugtracking.model;

namespace BugTrackingSystem.com.bugtracking.controller
{
    class ProjectController
    {

        //method to get all projects list
        public DataTable GetAllProjects()
        {

            String query = "select projectID as 'Project ID', projectName AS 'Project Name', startDate as 'Start Date', endDate as 'End Date' from tbl_projects";
            DataTable dt = new Database().GetData(query);
            return dt;
        }

        //method to insert project
        public void InsertProjects(Project p) {
            String query = "INSERT INTO `tbl_projects` (`projectID`, `projectName`, `startDate`, `endDate`) VALUES (NULL, '"+p.ProjectName+"', '"+p.StartDate+"', '"+p.EndDate+"');";
            new Database().InsertData(query);
        }

        //method to update project
        public void UpdateProject(Project p) {
            String query = "UPDATE `tbl_projects` SET `projectName` = '"+p.ProjectName+"', `startDate` = '"+p.StartDate+"', `endDate` = '"+p.EndDate+"' WHERE `tbl_projects`.`projectID` = "+p.ProjectID;
            new Database().UpdateData(query);
        }

        //method to delete project
        public void DeleteProject(Project p) {
            string query = "Delete from tbl_projects where projectID = " + p.ProjectID;
            Console.WriteLine(query);
            new Database().DeleteData(query);
        }

        //method to get project details
        public DataTable GetProjectDetails(int id) {
            String query = "select projectID, projectName, startDate, endDate from tbl_projects where projectID = "+id;
            DataTable dt = new Database().GetData(query);
            return dt;
        }

    }
}
