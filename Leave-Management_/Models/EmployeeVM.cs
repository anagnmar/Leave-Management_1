using System;
using System.Collections.Generic;


namespace Leave_Management_.Models
{
    public class EmployeeVM
    {

     // Properties from the IdentityUser Table

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

     //

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }


    }
}
