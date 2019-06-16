using System;

namespace Assessment.Library.Exception_handling
{
    public class NegativeNumberException : Exception
    {
        static string message = "Negative numbers are not allowed in this version";
        public NegativeNumberException() : base(message)
        {
        }
    }
}