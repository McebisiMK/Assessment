using Assessment.Library;
using System;

namespace Assessment
{
    public class Program
    {
        private static readonly double limit = 5;
        public static void Main(string[] args)
        {
            var terminator = "y";
            while (terminator == "y")
            {
                string response;
                Console.WriteLine($"Please enter a number less than {limit}");
                var numberDifferenceCalculator = new NumberDifferenceCalculator();
                var userInput = Console.ReadLine();
                try
                {
                    response = $"{numberDifferenceCalculator.GetDifference(userInput)}";
                    Console.WriteLine($"The number required to get to {limit} is {response}");
                }
                catch (Exception exception)
                {
                    response = exception.Message;
                    Console.WriteLine(response);
                }
                Console.WriteLine();
                Console.WriteLine("Press y to continue checking other possibilities else any key to exit");
                terminator = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}
