using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            //int ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);
            //tbAns.Text = ans.ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
        }

        private void tbTextArea_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void btPow_Click(object sender, EventArgs e) {

            /*int ans = Decimal.ToInt32(nudX.Value);
            int count = Decimal.ToInt32(nudY.Value);
            int num = ans;

            for (int i = 0; i < count - 1; i++) {ans = (ans * num);}
            
            tbResult.Text = ans.ToString();*/

            double resulut = Math.Pow((double)nudX.Value, (double)nudY.Value);
            tbResult.Text = resulut.ToString();

            //一行で書く場合↓
            //tbResult.Text = (Math.Pow((double)nudX.Value, (double)nudY.Value)).ToString();
        }
    }
}
