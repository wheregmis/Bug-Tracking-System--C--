using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class Project
    {
        //declaring variables
        private String projectName;
        private int projectID;
        private String startDate;
        private String endDate;

        //constructor
        public Project(int projectID)
        {
            this.projectID = projectID;
        }
        //constructor
        public Project(string projectName, String startDate, String endDate)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        //constructor
        public Project(int projectID, string projectName, String startDate, String endDate)
        {
            this.ProjectID = projectID;
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        //getter setter method
        public string ProjectName { get => projectName; set => projectName = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
    }
}
