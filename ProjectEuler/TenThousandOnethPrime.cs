using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class TenThousandOnethPrime : ISolution
    {
        public void Run()
        {
            Result = Enumerable.Range(2, int.MaxValue - 1).TakeWhile(x => x < int.MaxValue).Where(x => MathHelper.IsPrime(x)).Skip(10000).First();
        }

        public object Result { get; private set; }
    }
}
