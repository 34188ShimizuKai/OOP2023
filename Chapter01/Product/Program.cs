﻿using System;
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
            //DateTime date = new DateTime(2023, 5, 8);

            //DateTime date = DateTime.Today;
            //Console.WriteLine("今日の日付:" + date.Year + "年" + date.Month + "月" + date.Day + "日");

            //10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);
            //Console.WriteLine("10日後:" + daysAfter10.Year + "年" + daysAfter10.Month + "月" + daysAfter10.Day + "日");

            //10日前を求める
            //DateTime daysBefore10 = date.AddDays(-10);
            //Console.WriteLine("10日前:" + daysBefore10.Year + "年" + daysBefore10.Month + "月" + daysBefore10.Day + "日");
            #endregion

            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            String bYear = Console.ReadLine();
            Console.Write("月:");
            String bMonth = Console.ReadLine();
            Console.Write("日:");
            String bDay = Console.ReadLine();

            var bTmp = bYear + bMonth + bDay;

            var birthDay = new DateTime(int.Parse(bYear),int.Parse(bMonth), int.Parse(bDay));
            //Console.WriteLine(birthDay);

            DateTime dateTo = DateTime.Today;
            double interval = (dateTo - birthDay).TotalDays;
            Console.WriteLine("あなたは生まれてから{0}日目です。", interval);



        }
    }
}
