using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class PandigitalPrime : ISolution
    {
        public void Run()
        {
            //Result = MathHelper.PrimeSequence().AsParallel().TakeWhile(x => x <= 654321).Select(x => (int) x).LastOrDefault(x => Pandigitality(x) == 6);
            //Result = MathHelper.PrimeSequence().TakeWhile(x => x <= 54321).Count();
            Result = Enumerable.Range(2, 987654321 - 1).AsParallel()
                .Where(x => MathHelper.IsPrime(x))
                .Select(x => new { Number = x, Pandigitality = Pandigitality(x) })
                .Where(x => x.Pandigitality > 0)
                .Max(x => x.Number);
        }

        public object Result { get; private set; }

        private static readonly IDictionary<int, IEnumerable<char>> PandigitalitySequencesByN = new Dictionary<int, IEnumerable<char>>
        {
            { 9, "123456789" },
            { 8, "12345678" },
            { 7, "1234567" },
            { 6, "123456" },
            { 5, "12345" },
            { 4, "1234" },
            { 3, "123" },
            { 2, "12" },
            { 1, "1" }
        };

        private static int Pandigitality(int number)
        {
            var numberAsString = number.ToString();
            return PandigitalitySequencesByN.FirstOrDefault(x => x.Value.Intersect(numberAsString).Count() == numberAsString.Length && x.Value.Count() == numberAsString.Length).Key;
        }
    }
}
