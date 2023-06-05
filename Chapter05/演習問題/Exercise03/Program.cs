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
            #region　改善前1
            /*var cnt = 0;
            foreach (var t in text)
                if (t == ' ')
                    cnt++;
            Console.WriteLine("空白数:{0}", cnt);*/
            #endregion
            #region 改善前2
            //string[] word = text.Split(' ');
            //var cnt = -1;

            //foreach (var w in word)
            //    cnt++;

            //Console.WriteLine("空白数:{0}", cnt);
            #endregion
            Console.WriteLine("空白数:{0}",(from word in text.Split(' ') select word).Count() - 1);

        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine("変換結果:{0}",replaced);
        }

        private static void Exercise3_3(string text) {
            #region 改善前1
            /*string[] word = text.Split(' ');
            var cnt = 0;

            foreach (var w in word)
                cnt++;
            Console.WriteLine("単語数:{0}", cnt);*/
            #endregion
            Console.WriteLine("単語数:{0}", (from word in text.Split(' ') select word).Count());

        }

        private static void Exercise3_4(string text) {
            string[] word = text.Split(' ');
            foreach (var w in word)
                if (w.Length <= 4)
                    Console.WriteLine(w);
        }

        private static void Exercise3_5(string text) {
            string[] word = text.Split(' ');
            var sb = new StringBuilder();
            for(int i = 0; i < word.Length; i++) {
                sb.Append(word[i]);
                if(i < word.Length - 1)  {
                    sb.Append(' ');
                }
            }
            sb.Append('a');
            var reText = sb.ToString();
            Console.WriteLine(reText);
        }
    }
}
