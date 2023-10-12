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
            foreach (var year in Library.Books.Select(y => y.PublishedYear).Distinct().OrderBy(y => y))
                Console.WriteLine("西暦{0}年:{1}冊",year, Library.Books.Count(c => c.PublishedYear == year));
        }

        private static void Exercise1_4() {
            foreach (var book in Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(b => b.Price))
            {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_5() {
            Console.WriteLine("【2016年のカテゴリ一覧】");
            Console.Write("  ");
            foreach (var category in Library.Books.Where(b => b.PublishedYear == 2016).Select(c => c.CategoryId).Distinct())
            {
                Console.Write(category + " ");
            }
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
        
        }

        private static void Exercise1_8() {
        
        }
    }
}
