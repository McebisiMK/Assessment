using System;

namespace Assessment.Library
{
    public class InvalidInputException : Exception
    {
       static  string str = "Input exceeds the maximum allowed value";
        public InvalidInputException(double maxInput) : base($"{str} {maxInput}")
        {
        }
    }

}