using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);


        }

        private static void Exercise1_1(string text) {
            var alphabetDict = new Dictionary<Char, int>();
            foreach (var alphabet in text.ToUpper().Where(s => s != ' '))
            {

                if (alphabetDict.ContainsKey(alphabet))
                {
                    alphabetDict[alphabet] += 1;
                }
                else
                {

                    alphabetDict[alphabet] = 1;
                }
            }

            foreach (var item in alphabetDict.OrderBy(a => a.Key))
            {
                Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
        }

        private static void Exercise1_2(string text) {
 
        }
    }
}
