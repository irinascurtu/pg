using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx
{
    public class Mammal
    {
        public bool HasWarmBlood { get { return true; } }

        public Mammal() { }
        public Mammal(string name) { }

        public void GiveBirth()
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Mammal, and I make sounds!");
        }
    }
}
