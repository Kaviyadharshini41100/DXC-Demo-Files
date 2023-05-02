using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class InValidException : Exception
    {
        public InValidException() { }
        public InValidException(String message) : base (message) { }
    }
}
