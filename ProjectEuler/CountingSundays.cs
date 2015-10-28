using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class CountingSundays : ISolution
    {
        public void Run()
        {
            var from = new DateTime(1901, 1, 1);
            var until = new DateTime(2000, 12, 31);
            Result = FirstDayOfMonthSequence(from, until).Where(x => x.DayOfWeek == DayOfWeek.Sunday).Count();
        }

        public object Result { get; private set; }

        private static IEnumerable<DateTime> FirstDayOfMonthSequence(DateTime from, DateTime until)
        {
            var date = from.Day == 1 ? from : new DateTime(from.Year, from.Month, 1).AddMonths(1);
            while (date <= until)
            {
                yield return date;
                date = date.AddMonths(1);
            }
        }
    }
}
