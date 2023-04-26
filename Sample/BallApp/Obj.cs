using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    //抽象クラス
    abstract class Obj {
        //フィールド
        private Image image;    //画像データ
        private double posX;    //ｘ座標
        private double posY;    //ｙ座標
        private double moveX;   //移動量（ｘ方向）
        private double moveY;   //移動量（ｙ方向）
        //private static int cnt = 0;

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }
        //public int Cnt { get => cnt; set => cnt = value; }

        public Obj(double PosX, double PosY, string Path) {
            this.PosX = PosX;
            this.PosY = PosY;
            Image = Image.FromFile(Path);
            //his.Cnt = Cnt;
        }

        //移動メソッド（抽象メソッド）
        public abstract void Move();
    }
}
