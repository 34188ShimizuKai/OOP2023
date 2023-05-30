﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //4.1.1
    public class YearMonth {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }
        //4.1.2
        public bool Is21Century {
            get {
                return Year >= 2001 && Year <= 2100;
            }
        }
        //4.1.3
        public YearMonth AddOnemonth() {
            return new YearMonth(Month == 12 ? Year + 1 : Year, 
                                 Month < 12 ? Month + 1 : 1);
        }
        //4.1.4
        public override string ToString() {

            return Year + "年" + Month + "月";
        }
    }
}
