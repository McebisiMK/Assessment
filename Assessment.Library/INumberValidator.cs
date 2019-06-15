using System;

namespace Assessment.Library
{
    public interface INumberValidator
    {
        double Validate(string number, double limit);
    }
}