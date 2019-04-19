using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reg_A_Lot
{
    abstract class Person
    {
        

        // Creating the characteristics of 'Person'
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CollegeID { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public string Email { get; set; }
        

    }
}
