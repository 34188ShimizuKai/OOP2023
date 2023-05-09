using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //Product karinto = new Product(123,"かりんとう",180);//インスタンスの生成
            //Product daifuku = new Product(235, "大福もち", 160);


            //Console.WriteLine("かりんとうの税込価格：" + karinto.GetPriceIncludingTax());

            //Console.WriteLine("大福もちの税込価格：" + daifuku.GetPriceIncludingTax());}
            #endregion

            #region 演習1
            //var date = new DateTime(2023, 5, 8);

            //var date = DateTime.Today;
            //Console.WriteLine("今日の日付:" + date.Year + "年" + date.Month + "月" + date.Day + "日");

            //10日後を求める
            //var daysAfter10 = date.AddDays(10);
            //Console.WriteLine("10日後:" + daysAfter10.Year + "年" + daysAfter10.Month + "月" + daysAfter10.Day + "日");

            //10日前を求める
            //var daysBefore10 = date.AddDays(-10);
            //Console.WriteLine("10日前:" + daysBefore10.Year + "年" + daysBefore10.Month + "月" + daysBefore10.Day + "日");
            #endregion

            //誕生日入力処理
            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            var bYear = int.Parse(Console.ReadLine()) ;
            Console.Write("月:");
            var bMonth = int.Parse(Console.ReadLine());
            Console.Write("日:");
            var bDay = int.Parse(Console.ReadLine());

            //入力した年月日をDateTime型に変換
            var birth = new DateTime(bYear,bMonth,bDay);
            #region 演習2
            var dateTo = DateTime.Today;
            TimeSpan interval = dateTo - birth;
            Console.WriteLine("あなたは生まれてから{0}日目です。", interval.Days);
            #endregion

            Console.WriteLine("あなたは{0}曜日に生まれました。",birth.DayOfWeek);


        }
    }
}
