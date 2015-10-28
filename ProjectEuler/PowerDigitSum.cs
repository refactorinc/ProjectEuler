using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class PowerDigitSum : ISolution
    {
        public void Run()
        {
            var power = 1000;
            var number = BigInteger.Pow(new BigInteger(2), power);
            var digits = number.ToString().Select(x => x.ToString()).Select(x => Convert.ToInt32(x));
            var sumOfDigits = digits.Sum();
            Result = String.Format("{0} {1}", number, sumOfDigits);
        }

        public object Result { get; private set; }
    }
}
