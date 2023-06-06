﻿#define StringArray
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
#if NonArray
            int choicer = 1;
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            string[] titles = {"作家","代表作","誕生年"};
            string[] words = line.Split('=', ';').ToArray();
            for(int i = 0;i < words.Length / 2; i++) {
                Console.WriteLine("{0}:{1}", titles[i], words[i + choicer]);
                choicer++;
            }
#elif StringArray
            string[] lines = {
            "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
            "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1867",
            "Novelist=太宰治;BestWork=人間失格;Born=1909",
            "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896", };

            foreach (var line in lines){
            foreach(var pair in line.Split(';')){
                var array = pair.Split('=');
                Console.WriteLine("{0}:{1}",ToJapanese(array[0]),array[1]);
            }
        }

# endif
            Console.WriteLine("実行時間 = {0}",sw.Elapsed.ToString(@"ss\.fffff"));//実行時間
        }
        static string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("正しい引数ではありません");
        }
    }
}