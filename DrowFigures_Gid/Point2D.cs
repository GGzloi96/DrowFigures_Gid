using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrowFigures_Gid
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void AddX(int x)
        {
            X += x;
        }

        public void AddY(int y)
        {
            Y += y;
        }

    }
}
