using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbNow.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tmTimeDisp.Start();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            DateTime today = DateTime.Today;
            tbMessage.Text = (today - dtp).Days + "日";

        }
        private void btAge_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "貴方の年齢は" + age + "歳です。";
        }
        public static int GetAge(DateTime birthDay,DateTime targetDay) {
            var age = targetDay.Year - birthDay.Year;
            if(targetDay < birthDay.AddYears(age))
            {
                age--;
            }
            return age;
        }

        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbNow.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
