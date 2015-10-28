using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class LongestCollatzSequence : ISolution
    {
        public void Run()
        {
            var longestSequences = Enumerable.Range(1, 999999).AsParallel().Select(Sequence).OrderByDescending(x => x.Count()).ToList();

            var longestSequence = longestSequences.First();

            Result = String.Join(" --> ", longestSequence.Select(x => x.ToString()));
        }

        public object Result { get; private set; }

        static long Next(long number)
        {
            return number % 2L == 0L ? number / 2L : 3L * number + 1L;
        }

        static IEnumerable<long> Sequence(int start)
        {
            var number = (long)start;
            while (number != 1L)
            {
                yield return number;
                number = Next(number);
            }
            yield return 1L;
        }
    }
}
