using System;
using System.ComponentModel.Design;

namespace XUnitCumulativePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static bool ValidateOneToOneHundredEven(string input)
        {
            // Citation: https://codeasy.net/lesson/input_validation
            // Checks if the input can be parsed into an int, if so, it will be true
            int userNumber;
            return ((int.TryParse(input, out userNumber)) && (userNumber > 0) && (userNumber <= 100) &&
                    (userNumber % 2 == 0));
        }
    }
}