﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };
            var regex = new Regex(@"\b(T|t)ime\b");
            foreach (var text in texts)
            {
                var matches = regex.Matches(text);
                foreach (Match match in matches)
                {
                    Console.WriteLine("{0}:{1}",text,match.Index);
                }//var isMatch = regex.IsMatch(text);
                //if (isMatch)
                //    Console.WriteLine(text);
            }



        }
    }
}
