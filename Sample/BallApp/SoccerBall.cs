using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド
        private Image image;//画像データ

        private double posX;//X座標
        private double posY;//Y座標

        private double moveX = 0;//移動量（X方向）
        private double moveY = 0;//移動量（Y方向）
          Random r = new Random();
        //コンストラクタ
        public SoccerBall(double xp,double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = xp;
            PosY = yp;  

            while (moveX == 0 || moveY == 0){
                moveX = r.Next(-20, 20);
                moveY = r.Next(-20, 20);
            }
        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {
            posX += moveX;
            Console.WriteLine("座標X："　+ posX);
            posY += moveY;
            Console.WriteLine("座標Y：" + posY);
           
            if (PosX >= 750 || PosX < 0){
                moveX *= -1;
            }else if(PosY >= 530 || PosY < 0){
                moveY *= -1;
            }
        }
    }
}
