using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class DialogForm3 : Form
    {
        private string _selectValue;
        public DialogForm3(string selectValue)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _selectValue = selectValue;
        }

        public List<Figure> Figures = new List<Figure>();

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {
            if (WidthObjectTextBox.Text == "" || HeightObjectTextBox.Text == "" || CoordinateXtextBox.Text == "" || CoordinateYtextBox.Text == "" 
                || EpsilonTextBox.Text == "" || SigmaTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            int width = int.Parse(dialogForm2.WidthtextBox.Text);
            int height = int.Parse(dialogForm2.HeightTextBox.Text);

            double WidthObject = double.Parse(WidthObjectTextBox.Text);
            double HeightObject = double.Parse(HeightObjectTextBox.Text);
            double CoordinateX = double.Parse(CoordinateXtextBox.Text);
            double CoordinateY = double.Parse(CoordinateYtextBox.Text);
            double Epsilon = double.Parse(EpsilonTextBox.Text);
            double Sigma = double.Parse(SigmaTextBox.Text);

            if (CoordinateX >= 0 && CoordinateX <= width && CoordinateY >= 0 && CoordinateY <= height) //проверка, не выходит ли точка привязки за границы расчетной области
            {
                //передаем данные в класс
                Rectanglee rectanglee = new Rectanglee(CoordinateX, CoordinateY, WidthObject, HeightObject, Epsilon, Sigma);
                Figures.Add(rectanglee);
            }
            else
            {
                MessageBox.Show("Точка привязки прямоугольника выходит за границы расчетной области!", "Внимание", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }


            if (dialogForm2 != null)
            {
                foreach (Figure figure in Figures)
                {
                    dialogForm2.BoxForObjectListBox.Items.Add(string.Format("{0}: Ширина: {1}, Высота: {2}, " +
                        "Точка привязки: x = {3} y = {4}", _selectValue, WidthObject, HeightObject, figure.x, figure.y));
                    dialogForm2.Figures.Add(figure);
                }

                //ShowShapesOnChart(Figures, rectanglee);
            }
            this.Hide();
        }


        // Отображаем фигуры на Chart
        private void ShowShapesOnChart(List<Figure> shapes, Rectanglee rectanglee)
        {
            //DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            //foreach (Figure figure in shapes)
            //{
            //    Series series = new Series();
            //    series.ChartType = SeriesChartType.Point;
            //    series.MarkerSize = (int)Math.Max(rectanglee.Width, rectanglee.Height); // задаем размер символа
            //    series.MarkerStyle = MarkerStyle.Square;
            //    // Добавляем точку на элемент Chart
            //    series.Points.AddXY(figure.x, figure.y);
            //    // Добавляем серию на элемент Chart
            //    dialogForm2.chart1.Series.Add(series);

            //}



            //// Вычисляем координаты вершин прямоугольника
            //double left = rectanglee.BottomLeftPoint.X;
            //double top = rectanglee.BottomLeftPoint.Y;
            //double right = rectanglee.BottomLeftPoint.X + rectanglee.Width;
            //double bottom = rectanglee.BottomLeftPoint.Y - rectanglee.Height;

            //// Получаем объект Graphics для поверхности графика
            //Graphics graphics = dialogForm2.chart1.CreateGraphics();
            //// Устанавливаем преобразование координат для смещения начала координат вниз
            //graphics.TranslateTransform(0, dialogForm2.chart1.Height);

            //Random random = new Random();
            //Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            //// Заливаем прямоугольник красным цветом
            //graphics.FillRectangle(new SolidBrush(color), (float)left, (float)bottom, (float)rectanglee.Width, (float)rectanglee.Height);

            //// Рисуем прямоугольник на графике
            //graphics.DrawRectangle(Pens.Black, (float)left, (float)bottom, (float)rectanglee.Width, (float)rectanglee.Height);

            //// Освобождаем ресурсы
            //graphics.Dispose();

            DialogForm2 dialogForm2 = this.Owner as DialogForm2;

            int width = int.Parse(dialogForm2.WidthtextBox.Text);
            int height = int.Parse(dialogForm2.HeightTextBox.Text);
            // Создание объекта Bitmap для рисования графика
            Bitmap bitmap = new Bitmap(width, height);

            // Создание объекта Graphics из Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Получаем координаты вершин прямоугольника
                double left = rectanglee.BottomLeftPoint.X;
                double top = rectanglee.BottomLeftPoint.Y;
                double right = rectanglee.BottomLeftPoint.X + rectanglee.Width;
                double bottom = rectanglee.BottomLeftPoint.Y - rectanglee.Height;

                // Устанавливаем преобразование координат для смещения начала координат вниз
                //graphics.TranslateTransform(0, dialogForm2.chart1.Height);

                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                // Заливка прямоугольника цветом
                graphics.FillRectangle(new SolidBrush(color), (float)left, (float)bottom, (float)rectanglee.Width, (float)rectanglee.Height);

                // Рисование границы прямоугольника
                graphics.DrawRectangle(Pens.Black, (float)left, (float)bottom, (float)rectanglee.Width, (float)rectanglee.Height);

                // Отобразить графический объект на элементе управления Chart
                dialogForm2.chart1.CreateGraphics().DrawImage(bitmap, 0, 0);
            }

            // Освобождение ресурсов
            bitmap.Dispose();


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
