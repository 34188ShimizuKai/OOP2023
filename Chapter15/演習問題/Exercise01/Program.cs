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
            var books = Library.Books
                            .OrderByDescending(b => b.PublishedYear)
                            .ThenByDescending(b => b.Price)
                            .Join(Library.Categories,
                                  book => book.CategoryId,
                                  category => category.Id,
                                  (book, category) => new 
                                  {
                                      Title = book.Title,
                                      Category = category.Name,
                                      Price =book.Price,
                                      PublishedYear = book.PublishedYear
                                  }
                            );
            
            foreach (var book in books)
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.Category})");
        }

        private static void Exercise1_5() {
            Category categories = new Category(); 
            Console.WriteLine("【2016年のカテゴリ一覧】");
            var bookCategories = Library.Books
                            .Where(b => b.PublishedYear == 2016)
                            .Join(Library.Categories,
                                  book => book.CategoryId,
                                  category => category.Id,
                                  (book, category) => category.Name).Distinct();
            foreach (var category in bookCategories)
            {
                Console.WriteLine("・" + category);
            }
        }

        private static void Exercise1_6() {
            var groups = Library.Books
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    book.PublishedYear,
                    book.Price,
                    book.Title,
                    CategoryName = category.Name,
                }).GroupBy(g => g.CategoryName).OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                Console.WriteLine("#" + group.Key) ;
                foreach (var g in group)
                    Console.WriteLine(" " + g.Title);
              
            }
        }

        private static void Exercise1_7() {
            var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            var groups = Library.Books
                                .Where(b => b.CategoryId == catid)
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);
            foreach(var group in groups)
            {
                Console.WriteLine("#{0}年", group.Key);
                foreach (var book in group)
                {
                    Console.WriteLine("{0}", book.Title);
                }
            }
        }

        private static void Exercise1_8() {
            var query = Library.Categories
                                .GroupJoin(
                                    Library.Books,
                                    c => c.Id,
                                    b => b.CategoryId,
                                    (c, b) => new {
                                        CategoryName = c.Name,
                                        Count = b.Count()
                                    })
                                 .Where(x => x.Count >= 4);
            foreach (var category in query)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
