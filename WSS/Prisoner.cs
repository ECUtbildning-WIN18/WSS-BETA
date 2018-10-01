using System;
using System.Collections.Generic;
using System.Text;

namespace WSS
{
    class Prisoner
    {
        public string SocialSecurityNumber { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool IsAlive { get; private set; } = true;

        public Prisoner(string socialSecurityNumber, string firstName, string lastName, DateTime birthDate)
        {
            SocialSecurityNumber = socialSecurityNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
