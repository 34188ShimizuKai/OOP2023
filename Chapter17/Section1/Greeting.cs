using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1 {
    class GreetingMorning : GreetingBase{
        public override string GetMassage() {
            return "おはよう";
        }
    }
    class GreetingAfternoon : GreetingBase {
        public override string GetMassage() {
            return "こんにちは";
        }
    }

    class GreetingEvening : GreetingBase {
        public override string GetMassage() {
            return "こんばんは";
        }
    }
}
