using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Exceptions
{
    class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException() { }
        public PriceMustBeGratherThanZeroException(string message) : base(message) { }
        
    }
}
