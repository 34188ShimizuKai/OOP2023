using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj {

        //フィールド
        Random r = new Random();   //乱数インスタンス
        private static int cnt;
        private static int checker;

        public static int Cnt { get => cnt; set => cnt = value; }
        public static int Checker { get => checker; set => checker = value; }

        //プロパティ

        //コンストラクタ
        public SoccerBall(double xp, double yp)
            : base(xp, yp, @"pic\soccer_ball.png") {

            int rndX = r.Next(-25, 25);
            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定
            int rndY = r.Next(-25, 25);
            MoveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定

            Checker = 0;
            Cnt++;
        }

        //メソッド
        public override void Move(PictureBox pbBar,PictureBox pbBall) {
            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            Console.WriteLine("Ｘ座標 = {0}, Ｙ座標 = {1}", PosX, PosY);

            if (PosY > 520 || PosY < 0 || rBar.IntersectsWith(rBall)) {MoveY = -MoveY;}
            if (PosX > 730 || PosX < 0){MoveX = -MoveX;}
            PosX += MoveX;
            PosY += MoveY;
        }
        public override void Move(Keys direction) {
            ;
        }
    }
}
