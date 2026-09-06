using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrowFigures_Gid
{
    public class Rectangle
    {
        public Point2D MainP {  get; set; }
        public Point2D P2 { get; set; }

        public Point2D P3 { get; set; }

        public Point2D P4 { get; set; }

        public Rectangle(Point2D MainPoint, int Wight,  int Hight)
        {
            MainP = MainPoint;
            P2 = new Point2D(MainP.X + Wight,MainP.Y);
            P3 = new Point2D(P2.X , P2.Y+Hight);
            P4 = new Point2D(P3.X - Wight, P3.Y);


        }

        public void AddX(int x)
        {
            MainP.AddX(x);
            P2.AddX(x);
            P3.AddX(x);
            P4.AddX(x);

        }

        public void AddY(int y)
        {
            MainP.AddY(y);
            P2.AddY(y);
            P3.AddY(y);
            P4.AddY(y);

        }
    }
}
