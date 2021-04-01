using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipcalculator
{
    class CustomException : Exception          // inherting exception class  
    {
        public CustomException()
        {

        }
        public CustomException(string message) : base(message)       // defining base constructors
        {

        }
        public CustomException(string message, Exception innerException) : base(message, innerException)
        {


        }
    }
}
