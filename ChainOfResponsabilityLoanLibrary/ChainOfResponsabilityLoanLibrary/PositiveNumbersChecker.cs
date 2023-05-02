using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityLoanLibrary
{
    public class PositiveNumbersChecker : Checker
    {
        public override (bool, string) ProcessInput(string input)
        {
            var inputs = input.Split(',');
            bool isNumber1 = int.TryParse(inputs[0], out int number1);
            bool isNumber2 = int.TryParse(inputs[1], out int number2);

            if (isNumber1 && isNumber2 && number1 > 0 && number2 > 0)
            {
                int sum = number1 + number2;
                return (true, $"Sum: {sum}");
            }

            return (false, "Both numbers must be positive");
        }
    }
}
