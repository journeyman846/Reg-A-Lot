using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reg_A_Lot
{
    sealed class Student : Person
    {
        // Declare any variables needed for the Student class
        // Students need to be able to enter their first and last name, age, gender, collegeID, and address
        // Students need to be able to register for classes
        // Students will need to have access to quickly determine course availability and assigned professors
        // Student schedule information is protected from unauthorized access.
        

        public Student()
        {
            // Local variables to store into the Student class from the inherited Person class
            string firstName = FirstName;
            string lastName = LastName;
            string address = Address;
            int age = Age;
            int collegeID = CollegeID;
            int phoneNumber = PhoneNumber;
            string email = Email;
            string userName = UserName;
            string password = Password;
        }


    }
}
