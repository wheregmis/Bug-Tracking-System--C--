using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem.com.bugtracking.model
{
    class User
    {
        private int id;
        private string firstname;
        private string lastname;
        private string usertype;
        private string userrole;
        private string email;
        private string password;
        private string address;
        private string dob;
        private string gender;
        

        public User(string email)
        {
            this.email = email;
        }
        public User(int id)
        {
            this.id = id;
        }

        public User(int id, string firstname, string lastname, string email1, string password, string address, string userrole)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email1;
            this.password = password;
            this.address = address;
            this.userrole = userrole;
        }

        public User(string firstname, string lastname, string email1, string password, string address, string gender, string userrole, string dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email1;
            this.password = password;
            this.address = address;
            this.gender = gender;
            this.userrole = userrole;
            this.dob = dob;
        }

        public User(int id, string firstname, string lastname, string usertype, string userrole, string email, string password, string address, string dob, string gender)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.usertype = usertype;
            this.userrole = userrole;
           
            this.email = email;
            this.password = password;
            this.address = address;
            this.dob = dob;
            this.gender = gender;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Usertype { get => usertype; set => usertype = value; }
        public string Userrole { get => userrole; set => userrole = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}


