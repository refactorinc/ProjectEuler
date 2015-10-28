using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class MultiplesOfThreeAndFive : ISolution
    {
        public void Run()
        {
            Result = Enumerable.Range(1, 1000 - 1)
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();
        }

        public object Result { get; private set; }
    }
}
