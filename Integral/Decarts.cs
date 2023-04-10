using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integral
{
    internal class Decarts
    {
		private double x, y;
		public double X {get { return x; }set { x = value; }}
        public double Y { get { return y; } set { y = value; } }

        public Decarts(double a = 0, double b =0) {
            this.x = a;
            this.y = b;
        }

        public Decarts(ScreenPoints pointS, Size panel_size, Function f)
        {
            double indent_y = panel_size.Height / (f.maxY - f.minY);
            double indent_x = panel_size.Width / (f.maxX - f.minX);
            this.Y = f.maxY - pointS.Y / indent_y;//-minY
            //double minX, maxX;
            //maxX = panel_size.Width / (indent * 2);
            //minX = -maxX;
            this.X = f.minX + pointS.X / indent_x;
        }
    }
}
