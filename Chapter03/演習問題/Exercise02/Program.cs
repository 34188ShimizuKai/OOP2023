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
                if (names.Exists(s => s.Equals(search)).Equals(true)) 
                    Console.WriteLine(names.FindIndex(s => s.Equals(search)));
                else 
                    Console.WriteLine("-1");
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine(names.Count(s => s[0] == 'o'));
        }

        private static void Exercise2_3(List<string> names) {
            var contain = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in contain)
                Console.WriteLine(name);
        }

        private static void Exercise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith("B"))
                              .Select(s => new { s, s.Length });
            //var length = list.Select(s => s.Length);
            foreach (var item in selected)
                Console.WriteLine("{0},{1}",item.s,item.Length);
        }
    }
}
