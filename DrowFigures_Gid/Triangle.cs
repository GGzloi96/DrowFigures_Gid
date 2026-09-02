using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrowFigures_Gid
{
    public class Triangle
    {
        public Point2D P1 { get; set; }
        public Point2D P2 { get; set; }
        public Point2D P3 { get; set; }

        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public void AddX(int x)
        {
            P1.AddX(x);
            P2.AddX(x);
            P3.AddX(x);
        }

        public void AddY(int y)
        {
            P1.AddX(y);
            P2.AddX(y);
            P3.AddX(y);

        }
    }
}
