using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Rectanglee : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double EpsilonRec { get; set; }
        public double SigmaRec { get; set; }
        public Point BottomLeftPoint { get; set; } //поле для хранения точки привязки

        public Rectanglee(double x, double y, double width, double height, double epsilon, double sigma) : base(x,y, epsilon, sigma)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
            this.EpsilonRec = epsilon;
            this.SigmaRec = sigma;

            // Вычисляем координаты вершин прямоугольника
            double left = x;
            double bottom = y;

            // Устанавливаем точку привязки в левый нижний угол
            BottomLeftPoint = new Point((int)left, (int)bottom);
        }

        public override bool IsPointInFigure(Point point)
        {
            //расчет попадания координаты внутрь или на границу прямоугольника
            double xMin = x; //минимальные значения координат x
            double xMax = x + Width; //максимальные значения координат x
            double yMin = y; //минимальные значения координат y
            double yMax = y + Height; //максимальные значения координат y

            //Переменные xInBounds и yInBounds используются для проверки, находится ли заданная точка внутри границ прямоугольника.
            //Если xInBounds равен true, то координата x заданной точки находится между xMin и xMax
            bool xInBounds = (point.X >= xMin) && (point.X <= xMax);
            //Если yInBounds равен true, то координата y заданной точки находится между yMin и yMax
            bool yInBounds = (point.Y >= yMin) && (point.Y <= yMax);

            //Если обе переменные равны true, то точка находится внутри прямоугольника.
            return xInBounds && yInBounds;
        }
    }
}
