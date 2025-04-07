using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Exceptions
{
    class InvalidAgeException : System.Exception
    {
        public InvalidAgeException() { }
        public InvalidAgeException(string message) : base(message) { }
    }
}
