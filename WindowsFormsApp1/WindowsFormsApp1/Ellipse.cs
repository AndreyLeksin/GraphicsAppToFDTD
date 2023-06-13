using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Ellipse : Figure
    {
        public double r1 { get; set; }
        public double r2 { get; set; }
        public double f { get; set; }
        public double EpsilonEllips { get; set; }
        public double SigmaEllips { get; set; }

        public Ellipse(double x, double y, double r1, double r2, double f, double epsilon, double sigma) : base(x, y, epsilon, sigma)
        {
            this.x = x;
            this.y = y;
            this.r1 = r1;
            this.r2 = r2;
            this.f = f;
            this.EpsilonEllips = epsilon;
            this.SigmaEllips = sigma;
        }

        public override bool IsPointInFigure(Point point)
        {
            //расчет попадания координаты внутрь или на границу эллипса
            // Нормализуем координаты точки
            double xDiff = point.X - x;
            double yDiff = point.Y - y;
            double normX = xDiff / r1;
            double normY = yDiff / r2;

            // Вычисляем расстояние от заданной точки до двух фокусов
            double dist1 = Math.Sqrt(Math.Pow(xDiff + f, 2) + Math.Pow(yDiff, 2));
            double dist2 = Math.Sqrt(Math.Pow(xDiff - f, 2) + Math.Pow(yDiff, 2));

            // Проверяем, находится ли заданная точка внутри эллипса или на его границе
            return Math.Pow(normX, 2) + Math.Pow(normY, 2) <= 1 && Math.Abs(dist1 + dist2 - 2 * r1) <= Epsilon;
        }
    }
}
