using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1 {
    class GreetingMorning : IGreeting{
        public string GetMassage() {
            return "おはよう";
        }
    }
    class GreetingAfternoon : IGreeting {
        public string GetMassage() {
            return "こんにちは";
        }
    }

    class GreetingEvening : IGreeting {
        public string GetMassage() {
            return "こんばんは";
        }
    }
}
