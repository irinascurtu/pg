using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // 1. first name, last name, birthYear 
    // 2. Expose FirstName in a property
    // 3. expose a property named Age, that computes the age of the person
    // 4. Find a way to represent Gender for a person
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private Gender gender;

        public Person(string firstName, string lastName, int birthYear, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.gender = gender;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            //by marriage gets changed
            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - birthYear; }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
        }

    }
}
