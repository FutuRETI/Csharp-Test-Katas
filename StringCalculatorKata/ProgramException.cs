using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    [SerializableAttribute] 
    public class ProgramException : Exception
    {   
        public ProgramException()
        {
        }

        public ProgramException(string message) : base(message)
        {
        }

        public ProgramException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
