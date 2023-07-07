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
               Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(CarReport);
        }
        private CarReport.MakerGroup getSelectedMaker(){

            if (rbSubaru.Checked == true)
                return CarReport.MakerGroup.スバル;
            if (rbNissan.Checked == true)
                return CarReport.MakerGroup.日産;
            if (rbSuzuki.Checked == true)
                return CarReport.MakerGroup.スズキ;
            if (rbHonda.Checked == true)
                return CarReport.MakerGroup.ホンダ;
            if (rbDaihatsu.Checked == true)
                return CarReport.MakerGroup.ダイハツ;
            if (rbImport.Checked == true)
                return CarReport.MakerGroup.輸入車;
            if (rbOther.Checked == true)
                return CarReport.MakerGroup.その他;

            return CarReport.MakerGroup.トヨタ;
        }

    }
}
