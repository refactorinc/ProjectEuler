using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ISolution, MultiplesOfThreeAndFive>(typeof(MultiplesOfThreeAndFive).FullName);
            container.RegisterType<ISolution, EvenFibonacciNumbers>(typeof(EvenFibonacciNumbers).FullName);
            container.RegisterType<ISolution, LargestPrimeFactor>(typeof(LargestPrimeFactor).FullName);
            container.RegisterType<ISolution, LargestPalindromeProduct>(typeof(LargestPalindromeProduct).FullName);
            container.RegisterType<ISolution, SmallestMultiple>(typeof(SmallestMultiple).FullName);
            container.RegisterType<ISolution, SumSquareDifference>(typeof(SumSquareDifference).FullName);
            container.RegisterType<ISolution, TenThousandOnethPrime>(typeof(TenThousandOnethPrime).FullName);
            container.RegisterType<ISolution, LargestProductInASeries>(typeof(LargestProductInASeries).FullName);
            container.RegisterType<ISolution, SpecialPythagoreanTriplet>(typeof(SpecialPythagoreanTriplet).FullName);
            container.RegisterType<ISolution, SummationOfPrimes>(typeof(SummationOfPrimes).FullName);
            container.RegisterType<ISolution, LargestProductInAGrid>(typeof(LargestProductInAGrid).FullName);
            container.RegisterType<ISolution, HighlyDivisibleTriangularNumber>(typeof(HighlyDivisibleTriangularNumber).FullName);
            container.RegisterType<ISolution, LargeSum>(typeof(LargeSum).FullName);
            container.RegisterType<ISolution, LongestCollatzSequence>(typeof(LongestCollatzSequence).FullName);
            container.RegisterType<ISolution, CountingSundays>(typeof(CountingSundays).FullName);
            container.RegisterType<ISolution, PowerDigitSum>(typeof(PowerDigitSum).FullName);
            container.RegisterType<ISolution, NonAbundantSums>(typeof(NonAbundantSums).FullName);
            container.RegisterType<ISolution, AmicableNumbers>(typeof(AmicableNumbers).FullName);
            container.RegisterType<ISolution, FactorialDigitSum>(typeof(FactorialDigitSum).FullName);
            container.RegisterType<ISolution, OneThousandDigitFibonacciNumber>(typeof(OneThousandDigitFibonacciNumber).FullName);
            container.RegisterType<ISolution, PandigitalPrime>(typeof(PandigitalPrime).FullName);
            var solutions = container.ResolveAll<ISolution>().ToList();
            Console.WriteLine("Resolved {0} solution{1}.", solutions.Count, solutions.Count == 1 ? string.Empty : "s");

            solutions.ToList().ForEach(TimedRunEx);

            Console.ReadKey();
        }

        static void TimedRun(ISolution decorated)
        {
            var stopwatch = Stopwatch.StartNew();

            decorated.Run();

            stopwatch.Stop();

            Console.WriteLine("\n{0} - {1:0.00}s - {2}", decorated.GetType().Name, stopwatch.ElapsedMilliseconds / 1000.0, decorated.Result);
        }

        static void TimedRunEx(ISolution decorated)
        {
            var thread = new Thread(new ThreadStart(() => { TimedRun(decorated); }));

            thread.Start();

            if (!thread.Join(TimeSpan.FromMinutes(1)))
            {
                thread.Abort();
                Console.WriteLine("\n{0} - timed out", decorated.GetType().Name);
            }
        }
    }
}
