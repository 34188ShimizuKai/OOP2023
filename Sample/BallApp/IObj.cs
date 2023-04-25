using System.Drawing;

namespace BallApp {
    interface IObj {
        Image Image { get; set; }
        double PosX { get; set; }
        double PosY { get; set; }
    }
}