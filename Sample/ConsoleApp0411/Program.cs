using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            String[] moneyString = { "一万円札", "五千円札", "二千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉" };
            int[] moneyInteger = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
            int counter = 0;

            Console.Write("金額:");
            int sumMoney = int.Parse(Console.ReadLine());
            Console.Write("支払:");
            int pay = int.Parse(Console.ReadLine());
            int change = pay - sumMoney;
            Console.WriteLine("お釣:{0}円",change);

            for (int i = 0; i < moneyString.Length; i++)
            {
                //Console.Write(moneyString[i] + ":{0}枚",change / moneyInteger[i]);
                Console.Write(moneyString[i] + ":");
                while (change / moneyInteger[i] > counter)
                {
                    Console.Write("*");
                    counter++;
                }
                Console.WriteLine();
                counter = 0;
                change %= moneyInteger[i];
            }

            /*
            Console.WriteLine("五千円札:" + (change / 5000) + "枚");
            change %= 5000;

            Console.WriteLine("千円札：" + (change / 1000) + "枚");
            change %= 1000;

            Console.WriteLine("五百円玉:" + (change / 500) + "枚");
            change %= 500;

            Console.WriteLine("百円玉:" + (change / 100) + "枚");
            change %= 100;

            Console.WriteLine("五十円玉:" + (change / 50) + "枚");
            change %= 50;

            Console.WriteLine("十円玉:" + (change / 10) + "枚");
            change %= 10;
            
            Console.WriteLine("五円玉:" + (change / 5) + "枚");
            change %= 5;
            
             Console WriteLine("一円玉:" + (change / 1) + "枚");
            */
        }
    }
}
