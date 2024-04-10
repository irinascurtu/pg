using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Person : ICitizen
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public int Age
        {
            get { return age; }
        }

        public string SSN
        {
            get; set;
        }
    }
}
