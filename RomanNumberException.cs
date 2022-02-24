using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    public class RomanNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "number must be greater than 0";
            }
        }
    }
}
