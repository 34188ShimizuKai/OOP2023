using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var maxNumbers = numbers.Max();
            Console.WriteLine("最大値:{0}", maxNumbers);
        }

        private static void Exercise1_2(int[] numbers) {
            var backNumbers = numbers.Skip(numbers.Length - 4).ToArray();

            Console.Write("後ろから2個の要素:");

                Console.Write(backNumbers[0]);
                foreach (var n in backNumbers.Skip(1)) {
                    Console.Write(",");
                    Console.Write(n);
                }
            Console.WriteLine();
        }

        private static void Exercise1_3(int[] numbers) {
            
        }

        private static void Exercise1_4(int[] numbers) {
        }

        private static void Exercise1_5(int[] numbers) {
        }
    }
}
