using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class EvenFibonacciNumbers : ISolution
    {
        public void Run()
        {
            checked
            {
                Result = MathHelper.FibonacciSequence().TakeWhile(x => x <= 4000000).Where(x => x % 2 == 0).Sum();
            }
        }

        public object Result { get; private set; }
    }
}
