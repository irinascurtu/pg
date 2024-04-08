using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidSecondsException :InvalidSongException
    {
        public InvalidSecondsException(string message="The value should be between 0 and 59")
            :base(message)
        {
            
        }
    }
}
