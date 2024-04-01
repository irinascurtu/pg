using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private readonly string cnp;
        private readonly string firstName;
        private string lastName;
        // private decimal salary;


        public Person(string cnp, string firstName, string lastName)
        {
            this.cnp = cnp;
            this.firstName = firstName;
            this.lastName = lastName;
            //this.salary = 10000;
            this.Salary = 10000;
        }

        public string CNP
        {
            get
            {
                return cnp;
            }
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
            get { return lastName; }
        }

        // public decimal Salary { get { return salary; } }

        public decimal Salary { get; private set; }

        public void GetMarried(string newName)
        {
            this.lastName = newName;
            this.IncreaseSalary();
        }

        public void IncreaseSalary()
        {
            // this.salary = this.salary * (decimal)1.3;
            this.Salary =  Salary * (decimal)1.3;
        }
    }
}
