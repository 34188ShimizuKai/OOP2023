using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        //追加ボタンクリック時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var CarReport = new CarReport
            {
                Date = dtbDate.Value,
                Author = cbAuthor.Text,
               // Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(CarReport);
        }
        private CarReport.MakerGroup getSelectedMaker(){

            var RadioButtonChecked_InGroup = gbMaker.Controls.OfType<RadioButton>()
            .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup == rbToyota)      
                return CarReport.MakerGroup.トヨタ;
            if (RadioButtonChecked_InGroup == rbSubaru)
                return CarReport.MakerGroup.日産;
            return CarReport.MakerGroup.その他;
        }

    }
}
