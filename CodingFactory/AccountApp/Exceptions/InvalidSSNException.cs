using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Exceptions
{
    internal class InvalidSSNException : Exception
    {
        public InvalidSSNException(string s) : base(s)
        {
        
        } 

    }
}
