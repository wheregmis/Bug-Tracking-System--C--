﻿using System;
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

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Userrole { get => userrole; set => userrole = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}


