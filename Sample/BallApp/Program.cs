using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        private Timer moveTimer;
        //private Obj obj;
        private PictureBox pb;

        private List<Obj> balls = new List<Obj>();
        private List<PictureBox> pbs = new List<PictureBox>();

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;

            this.Text = "SoccerBall:0 TennisBall:0";

            this.MouseClick += Program_Click;

            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル（ms）
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
        }

        private void Program_KeyDown(object sender, KeyEventArgs e) {
            
        }

        //マウスクリック時のイベントハンドラ
        private void Program_Click(object sender, MouseEventArgs e) {

            Obj ballObj = null;
            pb = new PictureBox();
            //ボールインスタンス生成
            if (e.Button == MouseButtons.Left){
                ballObj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);

            }
            else if(e.Button == MouseButtons.Right){
                ballObj = new TennisBall(e.X - 15, e.Y - 15);
                pb.Size = new Size(30, 30);
            }

            //画像を表示するコントロール
            pb.Image = ballObj.Image;
            pb.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY); //画像の位置
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            balls.Add(ballObj);
            pbs.Add(pb);

            //this.Text = "BallGame:" + SoccerBall.Cnt;
            moveTimer.Start();  //タイマースタート
            
            this.Text = "SoccerBall:" + SoccerBall.Cnt + " TennisBall:" + TennisBall.Cnt;
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++)
            {
                    balls[i].Move();  //移動
                    pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY); //画像の位置
            }
    

        }
    }
}
