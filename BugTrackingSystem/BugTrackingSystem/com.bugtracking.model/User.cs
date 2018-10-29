using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class User
    {
        int userID;
        String username, firstName, lastName, email, address, dob, gender;

        public User(String name) {
            this.firstName = name;
        }

        public string GetUsername() {
            return username;
        }
        public string getFirstName()
        {
            return firstName;
        }
    }
}
