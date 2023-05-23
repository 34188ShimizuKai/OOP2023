using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 ,10, 55, 10, 15, 5};

            //5の倍数(自然数)
            //var count = numbers.Count(n => n % 5 == 0　&& n > 0);
            var sum = numbers.Where(n => n % 2 == 0).Average();

            Console.WriteLine(sum);
        }

    }
}