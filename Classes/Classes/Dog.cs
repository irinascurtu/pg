using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum Level
    {
        Beginner = 101,
        Intermediate = 200,
        Advanced = 500,
        SuperAdvanced = 1000
    }

    public enum Breed
    {
        Beagle,//0
        Labrador = 1,//1
        Husky = 2,//2, 1
        Bulldog, //3,
        Dalmatian,
        NotKnown
    }

    public class Dog
    {
        //compile time fields
        public const string Owner = "Gigi";
        protected readonly DateTime dateOfBirth;

        public static int numberOfInstances;

        //Attributes ; name, breed, size,

        // fields - keep the state of the class, and by default are private
        private string name;
        private string name1;
        private Breed breed;

        //property
        // public string Name { get; set; }//automatic property

        public string Name
        { //getter
            get
            {
                return name;
            }

            //setter
            set
            {
                name = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return Owner + " " + Name;
            }
        }

        public int Age { get; set; }


        //constructor
        public Dog() : this("N/A", Breed.NotKnown)
        {
            //name = "Spot";
            //numberOfInstances++;
        }

        //public Dog(string name, string breed)
        //{
        //    this.name = name;
        //  //  this.breed = breed;
        //    dateOfBirth = DateTime.Now;
        //    numberOfInstances++;
        //}

        public Dog(string name, Breed breed)
        {
            this.name = name;
            this.breed = breed;
            dateOfBirth = DateTime.Now;
            numberOfInstances++;
        }

        //Behavior/methods  - Bark , WiggleTail, Eat, Run

        public void Bark()
        {
            // dateOfBirth = DateTime.Now;
            Console.WriteLine($"woof woof, I'm {name}");
        }

        public void Eat()
        {
            Console.WriteLine("mniam mniam, good food, I'm eating...");
        }

        public static int GetInstanceNumber()
        {
            return numberOfInstances;
        }
    }
}
