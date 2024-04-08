using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidMinutesException : InvalidSongException
    {
        //0-14
        public InvalidMinutesException(string message="Minutes should be between 0 and 14.")
            : base(message) 
        {
            
        }
    }
}
