using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SumSquareDifference : ISolution
    {
        public void Run()
        {
            var firstTenNaturalNumbers = Enumerable.Range(1, 100).ToList();

            var sumOfSquares = firstTenNaturalNumbers.Select(x => x * x).Sum();
            var squareOfSums = Convert.ToInt32(Math.Pow(firstTenNaturalNumbers.Sum(), 2.0));

            Result = string.Format("{0} - {1} = {2}", squareOfSums, sumOfSquares, squareOfSums - sumOfSquares);
        }

        public object Result { get; private set; }
    }
}
