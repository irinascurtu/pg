using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Dogs
{
    public class Beagle : Dog
    {
        private readonly string trick;

        public Beagle(string name, string trick) : base(name)
        {
            Console.WriteLine("Beagle class");
            this.trick = trick;
        }

        public void DoTrick()
        {
            Console.WriteLine($"I'm doing {trick}");
        }

        public void Bark()
        {
            Console.WriteLine("Bark - Beagle class");
           // base.Bark();
        }
    }
}
