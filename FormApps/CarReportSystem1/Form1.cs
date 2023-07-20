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
        private int mode = 0;
        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
        }
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname))
                cbCarName.Items.Add(carname);
        }
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }
        //追加ボタンクリック時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();
            if (cbAuthor.Text.Equals(""))
            {
                statasLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text.Equals(""))
            {
                statasLabelDisp("車名を入力してください");
                return;
            }
            var CarReport = new CarReport
            {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
    
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
    
            CarReports.Add(CarReport);
            clear();
            maskAdmin();
            dgvCarReports.ClearSelection();


        }
        //入力リセット
        private void clear() {
            dtpDate.ResetText();
            cbAuthor.ResetText();
            cbCarName.ResetText();
            rbToyota.Checked = true;
            tbReport.ResetText();
            pbCarImage.Image = null;
        }
        private void maskAdmin() {
            if (dgvCarReports.Rows.Count == 0)
            {
                btModifyReport.Enabled = false;
                btDeleteReport.Enabled = false; 
            }
            else
            {
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;                
            }
            
        }
        //ラジオボタン基準にデータ抽出
        private CarReport.MakerGroup getSelectedMaker(){
            int tag = 0;
            foreach(var item in gbMaker.Controls)
            {
                if (((RadioButton)item).Checked)
                {
                    tag = int.Parse(((RadioButton)item).Tag.ToString());
                    break;
                }
            }
            return (CarReport.MakerGroup)tag;

            #region 冗長
            /*if (rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            if (rbSuzuki.Checked)
                return CarReport.MakerGroup.スズキ;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.ホンダ;
            if (rbDaihatsu.Checked)
                return CarReport.MakerGroup.ダイハツ;
            if (rbImport.Checked)
                return CarReport.MakerGroup.輸入車;
            if (rbOther.Checked)
                return CarReport.MakerGroup.その他;

            return CarReport.MakerGroup.トヨタ;*/
            #endregion
        }
        //ラジオボタン
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup)
            {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
            //画像出力
        }
        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK)
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }
        //入力済データ削除
        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            maskAdmin();
            clear();
        }
        //データグリッドビュー
        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }
        //修正
        private void btModifyReport_Click(object sender, EventArgs e) {
            statasLabelDisp();
            if (cbAuthor.Text.Equals(""))
            {
                statasLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text.Equals(""))
            {
                statasLabelDisp("車名を入力してください");
                return;
            }
            CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            dgvCarReports.Refresh();    //一覧更新
            clear();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ヘルプHToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK)
                BackColor = cdColor.Color;
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ++mode : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }
    }
}