using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class HighlyDivisibleTriangularNumber : ISolution
    {
        public void Run()
        {
            var howManyDivisors = 500;

            Result = MathHelper.TriangleNumberSequence().First(x => MathHelper.FactorsOf(x).Count() > howManyDivisors);
        }

        public object Result { get; private set; }
    }
}
