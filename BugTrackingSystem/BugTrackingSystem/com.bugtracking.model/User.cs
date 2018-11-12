using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class User
    {

        int id;
        String username, userrole, firstName, lastName, email, address, dob, gender;
        private string user_username;
        private string password;

        public User(string user_username, string firstname, string lastname, string email, string password, string address, string gender, string userrole, string dob)
        {
            this.username = user_username;
            this.firstName = firstname;
            this.lastName = lastname;
            this.email = email;
            this.Password = password;
            this.address = address;
            this.gender = gender;
            this.userrole = userrole;
            this.dob = dob;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Userrole { get => userrole; set => userrole = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Password { get => password; set => password = value; }
    }
}


