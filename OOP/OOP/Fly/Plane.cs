using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    internal class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Wrrum, I'm starting the engines");
        }
    }
}
