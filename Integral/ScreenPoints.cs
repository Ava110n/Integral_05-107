using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class ScreenPoints
    {
        private int x, y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public ScreenPoints(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public ScreenPoints(Decarts A)
        {
            this.x = Convert.ToInt32(A.X);
            this.y = Convert.ToInt32(A.Y);
        }

        public ScreenPoints(Decarts A, Size panel_size, Function f)
        {
            double indent_y = panel_size.Height / (f.maxY - f.minY);
            double indent_x = panel_size.Width / (f.maxX - f.minX);
            this.Y = Convert.ToInt32((-A.Y + f.maxY) * indent_y); 
            //maxX = panel_size.Width / (indent * 2);
            //minX = -maxX;
            this.X = Convert.ToInt32((A.X - f.minX) * indent_x);
        }


        public Point toPoint(ScreenPoints A)
        {
            return new Point(A.x, A.y);
        }


    }
}
