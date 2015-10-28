using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SmallestMultiple : ISolution
    {
        public void Run()
        {
            var factors = new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Result = FactoredSequence(20).First(x => factors.All(y => x % y == 0));
        }

        public object Result { get; private set; }

        static IEnumerable<int> FactoredSequence(int factor)
        {
            var i = 1;
            while (true)
            {
                yield return factor * i++;
            }
        }
    }
}
