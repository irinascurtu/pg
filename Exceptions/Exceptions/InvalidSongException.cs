using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidSongException : ApplicationException
    {
     
        //this.Method() - this is current instance
        //base.Method() - calls Method from the base class

        public InvalidSongException(string message = "Invalid song") :
            base(message)//linking constructor
        { 
          
        }

    }
}
