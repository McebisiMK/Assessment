using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Library
{
    public class NumberValidator : INumberValidator
    {
        public double Validate(string number, double limit)
        {
            var maximumInput = limit - 1;
            double inputNUmber;
            try
            {
                inputNUmber = double.Parse(number);
            }
            catch (FormatException)
            {
                throw new FormatException("Given input is not convertable to a number");
            }

            if (inputNUmber > maximumInput)
            {
                throw new InvalidInputException(maximumInput);
            }

            if (inputNUmber < 0)
            {
                throw new NegativeNumberException();
            }

            return inputNUmber;
        }
    }
}
