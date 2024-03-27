using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    internal class PaperAiplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm launched by a human hand!");
        }

        public void Stop() { } 
        public void Stop2(){ }
    }
}
