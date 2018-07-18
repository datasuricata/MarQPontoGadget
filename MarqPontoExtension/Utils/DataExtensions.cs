using System;
using System.Collections.Generic;
using System.Linq;

namespace MarqPontoExtension.Utils
{
    public static class DataExtensions
    {
        public static double CalcTotalHoursFromTimeSpan(List<TimeSpan> list)
        {
            var totalPar = list.Count / 2;

            TimeSpan total = new TimeSpan(0, 0, 0);

            for (int i = 0; i < totalPar; i++)
            {
                var items = list
                    .Skip(i * 2)
                    .Take(2)
                    .Select(x => x).ToList();

                total = total + items.LastOrDefault() - items.FirstOrDefault();

            }

            return total.TotalMinutes;

        }

        public static string ReturnString(object Value)
        {
            return Value == null ? "" : Convert.ToString(Value.ToString());
        }
    }
}
