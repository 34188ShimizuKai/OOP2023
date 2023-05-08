using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    
    //商品クラス
    class Program {
        static void Main(string[] args) {
            Product karinto = new Product(123,"かりんとう",180);//インスタンスの生成
            Product daifuku = new Product(235, "大福もち", 160);

        
            Console.WriteLine("かりんとうの税込価格：" + karinto.GetPriceIncludingTax());
         
            Console.WriteLine("大福もちの税込価格：" + daifuku.GetPriceIncludingTax());}
    }
}
