using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class AmicableNumbers : ISolution
    {
        public void Run()
        {
            var amicableNumberBelow9999 = Enumerable.Range(1, 9999).Where(IsAmicable).ToList();
            Result = String.Format("{0} --> E({1})",
                                   String.Join(", ", amicableNumberBelow9999),
                                   amicableNumberBelow9999.Sum());
        }

        public object Result { get; private set; }

        private static bool IsAmicable(int number)
        {
            var sumOfProperDivisors = MathHelper.FactorsOf(number).Where(x => x != number).Sum();
            var sumOfProperDivisorsOfSumOfProperDivisors = MathHelper.FactorsOf(sumOfProperDivisors).Where(x => x != sumOfProperDivisors).Sum();
            return sumOfProperDivisorsOfSumOfProperDivisors != sumOfProperDivisors && sumOfProperDivisorsOfSumOfProperDivisors == number;
        }
    }
}
