using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    public abstract class Mammal
    {
        public void Move()
        {
            Console.WriteLine("i'm moving...");
        }

        public void Sleep()
        {
            Console.WriteLine("sleeeeeep....");
        }

        public abstract void Eat();
    }
}
