using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class Bug
    {
        private int bugID;
        private string bugTitle;
        private string project;
        private string line;
        private string method;
        private string bugClass;
        private string notes;
        private string code;
        private Image file;
        private string priority;
        private object resolved;
        private object comments;
        private string date;
        private object reportedBy;
        private object resolvedBy;

        public Bug(string bugTitle, string project, string line, string method, string bugClass, string notes, string code, Image file, string priority, string date, string reportedBy)
        {
            this.bugTitle = bugTitle;
            this.project = project;
            this.line = line;
            this.method = method;
            this.bugClass = bugClass;
            this.notes = notes;
            this.code = code;
            this.file = file;
            this.priority = priority;
            this.date = date;
            this.reportedBy = reportedBy;
        }

        public Bug(string bugTitle, string project, string line, string method, string bugClass, string notes, string code, Image file, string priority, object resolved, object comments, string date, object reportedBy, object resolvedBy)
        {
            this.BugTitle = bugTitle;
            this.Project = project;
            this.Line = line;
            this.Method = method;
            this.BugClass = bugClass;
            this.Notes = notes;
            this.Code = code;
            this.File = file;
            this.Priority = priority;
            this.Resolved = resolved;
            this.Comments = comments;
            this.Date = date;
            this.ReportedBy = reportedBy;
            this.ResolvedBy = resolvedBy;
        }

        public int BugID { get => bugID; set => bugID = value; }
        public string BugTitle { get => bugTitle; set => bugTitle = value; }
        public string Project { get => project; set => project = value; }
        public string Line { get => line; set => line = value; }
        public string Method { get => method; set => method = value; }
        public string BugClass { get => bugClass; set => bugClass = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Code { get => code; set => code = value; }
        public Image File { get => file; set => file = value; }
        public string Priority { get => priority; set => priority = value; }
        public object Resolved { get => resolved; set => resolved = value; }
        public object Comments { get => comments; set => comments = value; }
        public string Date { get => date; set => date = value; }
        public object ReportedBy { get => reportedBy; set => reportedBy = value; }
        public object ResolvedBy { get => resolvedBy; set => resolvedBy = value; }
    }
}
