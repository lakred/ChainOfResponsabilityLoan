using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityLoanLibrary
{
    public class NumberPair:Checker
    {
        public override (bool, string) ProcessInput(string input)
        {
            var inputs = input.Split(',');

            if (inputs.Length != 2)
            {
                return (false, "Input must contain two values");
            }

            bool isNumber1 = int.TryParse(inputs[0], out int number1);
            bool isNumber2 = int.TryParse(inputs[1], out int number2);

            if (!isNumber1 || !isNumber2)
            {
                return (false, "Both values must be numeric");
            }

            if (_successor != null)
            {
                return _successor.ProcessInput(input);
            }

        }

    }

    
    
}