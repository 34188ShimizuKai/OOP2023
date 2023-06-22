using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            #region 例
            /*var flowerDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };
            //flowerDict["morning glory"] = 250;
            String name = Console.ReadLine();
            int price = Console.Read();

            flowerDict.Add(name, price);

            //flowerDict.Add("morning glory",250);

            Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);
            Console.WriteLine("アサガオの価格は{0}円です。", flowerDict["morning glory"]);*/
            #endregion

            var prefDict = new Dictionary<string, string>();

            Console.WriteLine("※終了時は県名に「999」を入力");
            Console.Write("県名:");
            string pref = Console.ReadLine();
            string capital;
            string duplication;

            while (pref != ("999") && pref != ("９９９")) {
                Console.Write("所在地:");
                capital = Console.ReadLine();

                if (prefDict.ContainsKey(pref)) {
                    Console.WriteLine("既に存在している県名が入力されています。");
                    Console.WriteLine("上書きしますか？(はい:0,いいえ:1)");
                    Console.Write(">");
                    duplication = Console.ReadLine();

                    if (duplication == "0" || duplication == "０") {
                        prefDict[pref] = capital;
                    }
                } else {
                    prefDict.Add(pref, capital);
                }
                Console.WriteLine();
                Console.Write("県名:");
                pref = Console.ReadLine();

            }

            Console.WriteLine();

            Console.WriteLine("1:一覧表示 2:県名指定");
            Console.Write(">");
            string choicer = Console.ReadLine();

            if (choicer == "1" || choicer == "１") {
                foreach (var p in prefDict) {
                    Console.WriteLine("{0}({1})", p.Key, p.Value);
                }
            }
            if (choicer == "2" || choicer == "２") {
                Console.Write("県名を入力:");
                string searcher = Console.ReadLine();

                if (prefDict.ContainsKey(searcher)) {
                    Console.WriteLine("{0}です。", prefDict[searcher]);
                } else {
                    Console.WriteLine("{0}のデータは存在しません。", searcher);
                }
            }
        }
    }
}
