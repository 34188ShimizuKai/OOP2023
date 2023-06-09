﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {

        //コンストラクタ
        public Bar(double xp, double yp)
            : base(xp, yp, @"pic\bar.png") {

            MoveX = 70;
            MoveY = 0;

        }

        //メソッド
        public override void Move(PictureBox pbBar,PictureBox pbBall) {; }
         
        public override void Move(Keys direction) {
            if (direction == Keys.Right)
            {
                if (PosX < 635)
                {
                    PosX += MoveX;
                }
            }
            else if(direction == Keys.Left)
            {
                if(PosX > 0)
                {
                    PosX -= MoveX;
                }
            }
        }
        
    }
}