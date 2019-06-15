using System;

namespace Assessment.Library
{
    public class NumberDifferenceCalculator
    {
        private readonly INumberValidator numberValidator;
        private readonly double limit;

        public NumberDifferenceCalculator() : this(new NumberValidator(), 5)
        {
        }

        public NumberDifferenceCalculator(double limit) : this(new NumberValidator(), limit)
        {
        }

        public NumberDifferenceCalculator(INumberValidator numberValidator, double limit)
        {
            this.numberValidator = numberValidator;
            this.limit = limit;
        }

        public double GetDifference(string number)
        {
            double inputNUmber = this.numberValidator.Validate(number, limit);

            return (Math.Round(limit- inputNUmber, 2));
        }
    }
}