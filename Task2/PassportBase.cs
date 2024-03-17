using System;


namespace ConsoleApp5.Task2
{
    internal class PassportBase
    {
       
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        public string PassportNumber { get; set; }

        
        public PassportBase(string lastName, string firstName, string dateOfBirth, string passportNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            PassportNumber = passportNumber;
        }

        public virtual void Show()
        {
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Date of Birth: " + DateOfBirth);
            Console.WriteLine("Passport Number: " + PassportNumber);
        }
    }

}
