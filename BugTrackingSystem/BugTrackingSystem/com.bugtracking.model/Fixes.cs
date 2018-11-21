using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class Fixes
    {
        private int bugID;
        private string resolveCode;
        private string comments;
        private string resolvedBy;
        private String resolvedDate;

        public Fixes(int bugID, string resolveCode, string comments, string resolvedBy, string resolvedDate)
        {
            this.BugID = bugID;
            this.ResolveCode = resolveCode;
            this.Comments = comments;
            this.ResolvedBy = resolvedBy;
            this.ResolvedDate = resolvedDate;
        }

        public int BugID { get => bugID; set => bugID = value; }
        public string ResolveCode { get => resolveCode; set => resolveCode = value; }
        public string Comments { get => comments; set => comments = value; }
        public string ResolvedBy { get => resolvedBy; set => resolvedBy = value; }
        public string ResolvedDate { get => resolvedDate; set => resolvedDate = value; }
    }
}
