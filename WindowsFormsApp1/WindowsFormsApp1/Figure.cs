using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        public double x { get; set; }
        public double y { get; set; }
        public double Epsilon { get; set; }
        public double Sigma { get; set; }

        public Figure(double x, double y, double epsilon, double sigma)
        {
            this.x = x;
            this.y = y;
            this.Epsilon = epsilon;
            this.Sigma = sigma;
        }

        public abstract bool IsPointInFigure(Point point);
    }
}
