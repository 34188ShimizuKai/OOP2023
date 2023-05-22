using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");

            Console.WriteLine("１：店舗別売り上げ");
            Console.WriteLine("２：商品カテゴリ別売り上げ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                var amountPerStore = sales.GetPerStoreSales();
                foreach (var obj in amountPerStore){
                    Console.WriteLine("{0} {1:#,0}", obj.Key, obj.Value);
                }
            }else if(choice == 2){
                var amountPerProduct = sales.GetPerProductSales();
                foreach (var obj in amountPerProduct){
                    Console.WriteLine("{0} {1:#,0}", obj.Key, obj.Value);
                }
            }
        }
    }
}
