using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Console.WriteLine("***** 3.1 *****");
            Exercise2_1(names);
            Console.WriteLine();
            Console.WriteLine("***** 3.2 *****");
            Exercise2_2(names);
            Console.WriteLine();
            Console.WriteLine("***** 3.3 *****");
            Exercise2_3(names);
            Console.WriteLine();
            Console.WriteLine("***** 3.4 *****");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var search = Console.ReadLine();
                if (string.IsNullOrEmpty(search))
                    break;
                if (names.Exists(s => s == search) == true) 
                    Console.WriteLine(names.FindIndex(s => s == search));
                else 
                    Console.WriteLine("-1");
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine(names.Count(s => s[0] == 'T'));
        }

        private static void Exercise2_3(List<string> names) {
            var list = names.Where(s => s.Contains('o')).ToList();
            foreach (var item in list)
                Console.WriteLine(item);
        }

        private static void Exercise2_4(List<string> names) {
            var list = names.Where(s => s[0] == 'B').ToList();
            //var length = list.Select(s => s.Length);
            foreach (var item in list.Select(s => s.Length))
                Console.WriteLine(item);
        }
    }
}
