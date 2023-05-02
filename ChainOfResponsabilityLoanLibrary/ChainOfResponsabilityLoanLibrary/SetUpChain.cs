using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityLoanLibrary
{
    public class SetUpChain
    {
        private readonly Checker _chain;

        public SetUpChain()
        {
            var pairOfNumbers = new NumberPair();
            var positiveNumbers = new PositiveNumbersChecker();

            pairOfNumbers.SetSuccessor(positiveNumbers);
            _chain = pairOfNumbers;
        }

        public Checker GetChain => _chain;
    }
}

