using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class LargestPrimeFactor : ISolution
    {
        public void Run()
        {
            var number = 600851475143L;

            Result = MathHelper.FactorsOf(number).Where(MathHelper.IsPrime).Last();
        }

        public object Result { get; private set; }
    }
}
