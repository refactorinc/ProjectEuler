using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class MathHelper
    {
        public static IEnumerable<int> FibonacciSequence()
        {
            var a = 0;
            var b = 1;

            while (true)
            {
                var c = a + b;

                yield return c;

                a = b;
                b = c;
            }
        }

        public static bool IsPrime(long number)
        {
            return FactorsOf(number).All(x => x == 1L || x == number);
        }

        public static List<long> FactorsOf(long number)
        {
            var divisors = new List<long>();

            var lowDivisor = 1L;
            var highDivisor = number;

            while (lowDivisor <= highDivisor)
            {
                var divisionResult = number / lowDivisor;
                if (divisionResult * lowDivisor == number)
                {
                    divisors.Add(lowDivisor);
                    divisors.Add(divisionResult);
                }
                lowDivisor++;
                highDivisor = divisionResult +1L;
            }

            return divisors.Distinct().OrderBy(x => x).ToList();
        }

        public static IEnumerable<int> SequenceOfNumbersWithXDigits(int numberOfDigits)
        {
            if (numberOfDigits <= 0)
                throw new ArgumentException("Can only return numbers with one or more digits", "numberOfDigits");

            var smallestNumberWithXDigits = Convert.ToInt32(Math.Pow(10, numberOfDigits - 1));
            var largestNumberWithXDigits = Convert.ToInt32(Math.Pow(10, numberOfDigits) - 1);

            for (var i = smallestNumberWithXDigits; i <= largestNumberWithXDigits; i++)
            {
                yield return i;
            }
        }

        public static int Reflect(int number)
        {
            var reflection = String.Join(String.Empty, number.ToString().Reverse());

            return Convert.ToInt32(reflection);
        }

        public static IEnumerable<long> PrimeSequence()
        {
            yield return 2L;
            for (var i = 3L; i <= long.MaxValue; i += 2L)
            {
                if (IsPrime(i))
                {
                    System.Diagnostics.Debug.WriteLine("Emitting {0}", i);
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> TriangleNumberSequence()
        {
            var counter = 1;
            var nextTriangleNumber = 0;

            while (nextTriangleNumber < Int32.MaxValue)
            {
                yield return (nextTriangleNumber += counter++);
            }
        }

        public static IEnumerable<int> Digits(BigInteger number)
        {
            return number.ToString().Select(x => x.ToString()).Select(x => Convert.ToInt32(x));
        }
    }
}
