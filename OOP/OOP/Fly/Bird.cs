using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    internal class Bird : IBird // IFlyable, ILandBound
    {
        public void Fly()
        {
            Console.WriteLine("flap flap, I'm flying, I'm a bird");
        }

        public void Walk()
        {
            Console.WriteLine("Lalala, I'm walking on earth!");
        }
    }
}
