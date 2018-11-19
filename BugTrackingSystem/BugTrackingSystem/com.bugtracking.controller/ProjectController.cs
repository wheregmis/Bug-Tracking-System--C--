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

        public DataTable GetAllProjects()
        {

            String query = "select projectID as 'Project ID', projectName AS 'Project Name', startDate as 'Start Date', endDate as 'End Date' from tbl_projects";
            DataTable dt = new Database().getData(query);
            return dt;
        }

        public void insertProjects(Project p) {
            String query = "INSERT INTO `tbl_projects` (`projectID`, `projectName`, `startDate`, `endDate`) VALUES (NULL, '"+p.ProjectName+"', '"+p.StartDate+"', '"+p.EndDate+"');";
            new Database().insertData(query);
        }

        public void UpdateProject(Project p) {
            String query = "UPDATE `tbl_projects` SET `projectName` = '"+p.ProjectName+"', `startDate` = '"+p.StartDate+"', `endDate` = '"+p.EndDate+"' WHERE `tbl_projects`.`projectID` = "+p.ProjectID;
            new Database().updateData(query);
        }

        public void DeleteProject(Project p) {
            string query = "Delete from tbl_projects where projectID = " + p.ProjectID;
            Console.WriteLine(query);
            new Database().DeleteData(query);
        }

        public DataTable GetProjectDetails(int id) {
            String query = "select projectID, projectName, startDate, endDate from tbl_projects where projectID = "+id;
            DataTable dt = new Database().getData(query);
            return dt;
        }

    }
}
