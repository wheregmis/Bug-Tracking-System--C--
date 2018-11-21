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
    class BugFixesController
    {

        public DataTable GetBugFixes(int bugfixesID) {
            string query = "select * from tbl_bugfixes where bugfixesID ="+bugfixesID;
            Console.WriteLine(query);
            DataTable dt = new Database().getData(query);
            return dt;
        }

        public DataTable GetFixesHistory(int bugID) {
            string query = "select resolvedBy as 'Resolved By', resolvedDate as 'Resolved On', bugfixesID as 'Bug Fix ID' from tbl_bugfixes where bugID =" + bugID;

            Console.WriteLine(query);

            DataTable dt = new Database().getData(query);
            return dt;
        }

        public void insertBugFixes(Fixes fx)
        {
            string query = "INSERT INTO `tbl_bugfixes` (`bugfixesID`, `bugFix`, `resolvedBy`, `comments`, `bugID`, `resolvedDate`) VALUES (NULL, '"+fx.ResolveCode+"', '"+fx.ResolvedBy+"', '"+fx.Comments+"', '"+fx.BugID+"', '"+fx.ResolvedDate+"')";
             new Database().insertData(query);
            Console.WriteLine(query);
        }
    }
}
