using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reg_A_Lot
{
    sealed class Professor : Person
    {
        // Declare any variables needed for the Professor class
        // Professors need to be able to enter their first and last name, age, gender, collegeID, and address
        // Professors need to be able to select sections to teach
        // Professors need to be able to enter grades into system

        public Professor()
        {
            // Local variables to store into the Professor class from the inherited Person class
            string firstName = FirstName;
            string lastName = LastName;
            string address = Address;
            int age = Age;
            int collegeID = CollegeID;
            string phoneNumber = PhoneNumber;
            string email = Email;
            string userName = UserName;
            string password = Password;
        }
    }
}
