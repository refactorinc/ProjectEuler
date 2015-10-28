using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class LargestPalindromeProduct : ISolution
    {
        public void Run()
        {
            var results = new Dictionary<int, Tuple<int, int, int>>();
            var largestKey = 0;

            var reversedSequence = MathHelper.SequenceOfNumbersWithXDigits(3).Reverse().ToList();

            foreach (var a in reversedSequence)
            {
                foreach (var b in reversedSequence)
                {
                    var sum = a + b;
                    if (largestKey > sum)
                    {
                        break;
                    }
                    var product = a * b;
                    if (IsPalindrome(product))
                    {
                        results[sum] = Tuple.Create(Math.Min(a, b), Math.Max(a, b), product);
                        largestKey = sum;
                        break;
                    }
                }
            }

            var result = results[largestKey];
            Result = string.Format("{0} x {1} = {2}", result.Item1, result.Item2, result.Item3);
        }

        public object Result { get; private set; }

        static bool IsPalindrome(int number)
        {
            return number == MathHelper.Reflect(number);
        }
    }
}
