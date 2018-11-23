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

        //method to get all details of the bug fix of a particular bug fix
        public DataTable GetBugFixes(int bugfixesID) {
            string query = "select * from tbl_fixes where bugfixesID =" + bugfixesID;
            Console.WriteLine(query);
            DataTable dt = new Database().GetData(query);
            return dt;
        }

        //method to get all the bugfixes of a particular bug
        public DataTable GetFixesHistory(int bugID) {
            string query = "select resolvedBy as 'Resolved By', resolvedDate as 'Resolved On', bugfixesID as 'Bug Fix ID' from tbl_fixes where bugID =" + bugID;

            Console.WriteLine(query);

            DataTable dt = new Database().GetData(query);
            return dt;
        }

        //insert bugfixes into database
        public void insertBugFixes(Fixes fx)
        {
            string query = "INSERT INTO `tbl_fixes` (`bugfixesID`, `bugFix`, `resolvedBy`, `comments`, `bugID`, `resolvedDate`) VALUES (NULL, '"+fx.ResolveCode+"', '"+fx.ResolvedBy+"', '"+fx.Comments+"', '"+fx.BugID+"', '"+fx.ResolvedDate+"')";
             new Database().InsertData(query);
            Console.WriteLine(query);
        }

        //method to update that if the bug fix worked or not(bug fix status)
        public void UpdateFixes(int bugID, String status) {
            string query = "UPDATE `tbl_fixes` SET `fixStatus` = '"+status+"' WHERE `tbl_fixes`.`bugfixesID` = "+bugID;
            new Database().UpdateData(query);
            Console.WriteLine(query);
        }
    }
}
