using Assessment.Library;
using Assessment.Library.Exception_handling;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests
{
    public class NumberDifferenceCalculatorTests
    {
        [Test]
        public void GetDifference_GivenEmptyStringAsNumber_ShouldThrowException()
        {
            //-----------------------Arrange----------------------------
            var userInput = "";
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //-----------------------Arrange----------------------------
            var exception = Assert.Throws<FormatException>(() => numberDifferenceCalculator.GetDifference(userInput));

            //-----------------------Arrange----------------------------
            exception.Message.Should().Be("Given input is not convertable to a number");
        }
        [TestCase("0", 5)]
        [TestCase("1", 4)]
        [TestCase("2", 3)]
        public void GetDifference_GivenPositiveNumber_ShouldReturnDifferenceToFive(string userInput, double expectedDifference)
        {
            //--------------------Arrange--------------------------
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //--------------------Act-------------------------------
            var result = numberDifferenceCalculator.GetDifference(userInput);

            //-------------------Assert----------------------------
            result.Should().Be(expectedDifference);
        }

        [TestCase("5")]
        [TestCase("11")]
        [TestCase("100")]
        public void GetDifference_GivenNumberGreaterThanFour_ShouldThrowException(string userInput)
        {
            //--------------------Arrange--------------------------
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //--------------------Act-------------------------------
            var exception = Assert.Throws<InvalidInputException>(() => numberDifferenceCalculator.GetDifference(userInput));

            //-------------------Assert----------------------------
            exception.Message.Should().Be("Input exceeds the maximum allowed value 4");
        }

        [TestCase("-1")]
        [TestCase("-11")]
        [TestCase("-100")]
        public void GetDifference_GivenNegativeNumber_ShouldThrowException(string userInput)
        {
            //--------------------Arrange--------------------------
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //--------------------Act-------------------------------
            var exception = Assert.Throws<NegativeNumberException>(() => numberDifferenceCalculator.GetDifference(userInput));

            //-------------------Assert----------------------------
            exception.Message.Should().Be("Negative numbers are not allowed in this version");
        }

        [TestCase("0.557", 4.44)]
        [TestCase("0.1111", 4.89)]
        [TestCase("3.5", 1.50)]
        [TestCase("3.5119", 1.49)]
        public void GetDifference_GivenDecimalNumberBetweenZeroAndFour_ShouldReturnDifferenceInTwoDecimalPlaces(string userInput, double expectedDifference)
        {
            //--------------------Arrange--------------------------
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //--------------------Act-------------------------------
            var result = numberDifferenceCalculator.GetDifference(userInput);

            //-------------------Assert----------------------------
            result.Should().Be(expectedDifference);
        }
        [TestCase("abc")]
        [TestCase("1.d")]
        [TestCase("2c")]
        [TestCase("abc 1")]
        [TestCase("5#")]
        [TestCase("5*")]
        public void GetDifference_GivenInvalidNumberFormat_ShouldThrowNumberFormatException(string userInput)
        {
            //--------------------Arrange--------------------------
            var numberDifferenceCalculator = CreateDifferenceCalculator();

            //--------------------Act-------------------------------
            var exception = Assert.Throws<FormatException>(() => numberDifferenceCalculator.GetDifference(userInput));

            //-------------------Assert----------------------------
            exception.Message.Should().Be("Given input is not convertable to a number");
        }
        private static NumberDifferenceCalculator CreateDifferenceCalculator()
        {
            return new NumberDifferenceCalculator();
        }
    }
}