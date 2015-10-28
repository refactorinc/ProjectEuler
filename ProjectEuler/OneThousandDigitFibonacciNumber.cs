using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class OneThousandDigitFibonacciNumber : ISolution
    {
        public void Run()
        {
            var numberOfDigits = 1000;
            Result = FibonacciSequence().TakeWhile(x => x.ToString().Length < numberOfDigits).Count() + 1;
        }

        public object Result { get; private set; }

        public static IEnumerable<BigInteger> FibonacciSequence()
        {
            var a = new BigInteger(1);
            var b = new BigInteger(1);

            yield return a;
            yield return b;

            while (true)
            {
                var c = a + b;

                yield return c;

                a = b;
                b = c;
            }
        }
    }
}
