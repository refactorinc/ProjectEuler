using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SpecialPythagoreanTriplet : ISolution
    {
        public void Run()
        {
            var sum = 1000;

            for (int i = 1; i < sum; i++)
            {
                for (int j = i + 1; j <= sum - i; j++)
                {
                    for (int k = j + 1; k <= sum - i - j; k++)
                    {
                        if (i + j + k == sum && Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2))
                        {
                            Result = string.Format("{0}² + {1}² = {2}² and {0} + {1} + {2} = {3} and {0} * {1} * {2} = {4}", i, j, k, sum, i * j * k);
                        }
                    }
                }
            }
        }

        public object Result { get; private set; }
    }
}
