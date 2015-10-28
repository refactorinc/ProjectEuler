using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class FactorialDigitSum : ISolution
    {
        public void Run()
        {
            checked
            {
                var factorial = Enumerable.Range(1, 100).Select(x => new BigInteger(x)).Aggregate(new BigInteger(1), (x, y) => x * y);
                var sumOfDigits = MathHelper.Digits(factorial).Sum();
                Result = String.Format("{0} {1}", factorial, sumOfDigits);
            }
        }

        public object Result { get; private set; }
    }
}
