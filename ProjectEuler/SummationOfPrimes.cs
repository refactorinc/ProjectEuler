using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SummationOfPrimes : ISolution
    {
        public void Run()
        {
            var stopAt = 2000000L;

            Result = MathHelper.PrimeSequence().TakeWhile(x => x < stopAt).Sum();
        }

        public object Result { get; set; }
    }
}
