using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Dogs
{
    public class Dog
    {
        private readonly string name;

        //public Dog()
        //{
        //    Console.WriteLine("Dog class");
        //}

        public Dog(string name)
        {
            this.name = name;
            Console.WriteLine("Dog class");
        }

        //public virtual void Bark()
        //{
        //    Console.WriteLine("Dog - Bark");
        //}

        public void Bark()
        {
            Console.WriteLine("Dog - Bark");
        }


        private void Snorr()
        {
            Console.WriteLine("I'm snorring");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }

        public void Sleep()
        {
            Snorr();
        }
    }
}
