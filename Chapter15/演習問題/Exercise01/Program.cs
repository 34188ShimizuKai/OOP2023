using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            foreach (var book in Library.Books.Where(b=> b.Price == Library.Books.Max(m=>m.Price)))
                Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var years = Library.Books.Select(y=>y.PublishedYear).Distinct().OrderBy(y=>y);

            foreach (var year in years)
            {
                var count = Library.Books.Count(c => c.PublishedYear == year);
                Console.WriteLine("西暦{0}年:{1}冊",year,count);
            }
        }

        private static void Exercise1_4() {
        
        }

        private static void Exercise1_5() {
        
        }

        private static void Exercise1_6() {
        
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
        
        }
    }
}
