using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class NonAbundantSums : ISolution
    {
        private readonly List<int> AbundantNumbers = Enumerable.Range(1, 28123).Where(IsAbundant).ToList();

        public void Run()
        {
            Result = Enumerable.Range(1, 28123).AsParallel().Where(CannotBeWrittenAsSumofAbundantNumbers).Sum();
        }

        public object Result { get; private set; }

        private static bool IsAbundant(int number)
        {
            var factors = MathHelper.FactorsOf(number).Where(x => x != number);
            var sumOfFactors = factors.Sum();
            return sumOfFactors > number;
        }

        private bool CanBeWrittenAsSumOfAbundantNumbers(int number)
        {
            var abundantNumbers = AbundantNumbers.Where(x => x < number).ToList();
            return abundantNumbers.Any(x => abundantNumbers.Any(y => y + x == number));
        }

        private bool CannotBeWrittenAsSumofAbundantNumbers(int number)
        {
            return !CanBeWrittenAsSumOfAbundantNumbers(number);
        }
    }
}
