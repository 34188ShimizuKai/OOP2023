using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            #region 使用例
            //var exists = list.Exists(s => s[4] == ' ');
            //Console.WriteLine(exists);


            //var name = list.Find(s => s.Length == 6);
            //Console.WriteLine(name);

            //var index = list.FindIndex(s => s == "Canberra");
            //Console.WriteLine(index);
            #endregion

            var names = list.ConvertAll(s => s.ToLower());
            names.ForEach(s => Console.WriteLine(s));
        }
    }
}
