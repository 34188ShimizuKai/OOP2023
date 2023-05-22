using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(" ＊＊＊＊＊売り上げ集計＊＊＊＊＊");
            Console.WriteLine();
            Console.WriteLine("１：店舗別売り上げ");
            Console.WriteLine("２：商品カテゴリ別売り上げ");
            var check = false;
            var sales = new SalesCounter(@"data\sales.csv");

            while (check == false) { 
                Console.Write(">");

                var choice = int.Parse(Console.ReadLine());
            
                if (choice == 1){
                    var amountPerStore = sales.GetPerStoreSales();
                    foreach (var obj in amountPerStore){
                        Console.WriteLine("{0} {1:#,0}", obj.Key, obj.Value);

                    }
                    check = true;
                }else if (choice == 2){
                    var amountPerProduct = sales.GetPerProductSales();
                    foreach (var obj in amountPerProduct){
                        Console.WriteLine("{0} {1:#,0}", obj.Key, obj.Value);
                    }
                    check = true;
                }else{
                    Console.WriteLine("指定された数値を入れてください");
                }
            }
        }
    }
}
