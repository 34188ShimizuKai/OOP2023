using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek)))
            {
                DateTime nextweek = NextDay(DateTime.Today,(DayOfWeek)dayofweek);
                Console.WriteLine("{0}の次週の{1}：{2}",DateTime.Today.ToString("yyyy/MM/dd(ddd)"),
                    nextweek.ToString("ddd曜日"),nextweek.ToString("yyyy/MM/dd(ddd)"));
            }
        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            days += 7;
            return date.AddDays(days);
        }

    }
}
