using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };
            Console.WriteLine(numbers.Average());
            var books = Books.GetBooks();
            var booksObj = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price);
            foreach (var book in booksObj)
                Console.WriteLine("{0}:{1}",book.Title,book.Price);

            Console.WriteLine("----------①----------");//タイトルに「物語」がつく作品の平均ページ数
            Console.WriteLine("平均ページ数:{0}",books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages));
            Console.WriteLine();

            Console.WriteLine("----------②----------");//タイトルが長い順に作品を並び替える
            foreach (var book in books.OrderByDescending(x => x.Title.Length))
                Console.WriteLine("{0}:{1}", book.Title, book.Pages);
            

        }
    }
}
