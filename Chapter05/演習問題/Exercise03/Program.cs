using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var cnt = 0;
            foreach (var t in text)
                if (t == ' ')
                    cnt++;
            Console.WriteLine("空白数:{0}", cnt);
            #region 改善前
            //string[] word = text.Split(' ');
            //var cnt = -1;

            //foreach (var w in word)
            //    cnt++;

            //Console.WriteLine("空白数:{0}", cnt);
            #endregion

        }

        private static void Exercise3_2(string text) {
            var result = text.Replace("big", "small");
            Console.WriteLine("変換結果:{0}",result);
        }

        private static void Exercise3_3(string text) {
            string[] word = text.Split(' ');
            var cnt = 0;

            foreach (var w in word)
                cnt++;
            Console.WriteLine("単語数:{0}", cnt);
            
        }

        private static void Exercise3_4(string text) {
            string[] word = text.Split(' ');
            foreach (var w in word)
                if (w.Length <= 4)
                    Console.WriteLine(w);
        }

        private static void Exercise3_5(string text) {
            var sb = new StringBuilder();
            foreach (var word in text.Split(' ')) {
                sb.Append(word + " ");
            }
            var reText = sb.ToString();
            Console.WriteLine(reText);
        }
    }
}
