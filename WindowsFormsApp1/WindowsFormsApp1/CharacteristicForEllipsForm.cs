using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class CharacteristicForEllipsForm : Form
    {
        private string _selectValue;
        public CharacteristicForEllipsForm(string selectValue)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _selectValue = selectValue;
        }

        public List<Figure> Figures = new List<Figure>();

        private void SaveObjectBtn_Click(object sender, EventArgs e)
        {
            if (r1TextBox.Text == "" || r2TextBox.Text == "" || FocalDistanceTextBox.Text == "" || 
                CoordinateXtextBox.Text == "" || CoordinateYtextBox.Text == "" || EpsilonTextBox.Text == "" || SigmaTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            int width = int.Parse(dialogForm2.WidthtextBox.Text);
            int height = int.Parse(dialogForm2.HeightTextBox.Text);

            double r1 = double.Parse(r1TextBox.Text);
            double r2 = double.Parse(r2TextBox.Text);
            double focalDistance = double.Parse(FocalDistanceTextBox.Text);
            double CoordinateX = double.Parse(CoordinateXtextBox.Text);
            double CoordinateY = double.Parse(CoordinateYtextBox.Text);
            double Epsilon = double.Parse(EpsilonTextBox.Text);
            double Sigma = double.Parse(SigmaTextBox.Text);

            if (CoordinateX >= 0 && CoordinateX <= width && CoordinateY >= 0 && CoordinateY <= height) //проверкf, не выходит ли точка привязки за границы расчетной области
            {
                //передаем данные в класс
                Ellipse ellipse = new Ellipse(CoordinateX, CoordinateY, r1, r2, focalDistance, Epsilon, Sigma);
                Figures.Add(ellipse);
            }
            else
            {
                MessageBox.Show("Точка привязки эллипса выходит за границы расчетной области!", "Внимание", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (dialogForm2 != null)
            {
                foreach (Figure figure in Figures)
                {
                    dialogForm2.BoxForObjectListBox.Items.Add(string.Format("{0}: Большая полуось = {1}, " +
                        "Малая полуось = {2}, Фокальное расстояние = {3}, Точка привязки: x = {4} y = {5}", 
                        _selectValue, r1, r2, focalDistance, CoordinateX, CoordinateY));
                    dialogForm2.Figures.Add(figure);
                }
                //ShowShapesOnChart(Figures, ellipse);
            }
            this.Hide();
        }

        // Отображаем фигуры на Chart
        private void ShowShapesOnChart(List<Figure> shapes, Ellipse ellipse)
        {
            //DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            //foreach (Figure figure in shapes)
            //{
            //    Series series = new Series();
            //    series.ChartType = SeriesChartType.Point;
            //    series.MarkerSize = (int)Math.Max(ellipse.r1, ellipse.r2, ellipse.f); // задаем размер символа
            //    series.MarkerStyle = MarkerStyle.Square;
            //    // Добавляем точку на элемент Chart
            //    series.Points.AddXY(figure.x, figure.y);
            //    // Добавляем серию на элемент Chart
            //    dialogForm2.chart1.Series.Add(series);

            //}


            //DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            //// Создаем серию для отображения эллипса
            //Series ellipseSeries = new Series();
            //ellipseSeries.ChartType = SeriesChartType.Point;
            //ellipseSeries.Color = Color.Blue; // цвет эллипса
            //ellipseSeries.MarkerSize = 5; // размер точек эллипса
            //ellipseSeries.MarkerStyle = MarkerStyle.Circle; // стиль отображения точек

            //// Задаем координаты точек, которые образуют эллипс
            //for (double angle = 0; angle < 360; angle += 1)
            //{
            //    double radians = angle * Math.PI / 180;
            //    double r = ellipse.r1 * ellipse.r2 / Math.Sqrt(Math.Pow(ellipse.r2 * Math.Cos(radians), 2) + 
            //        Math.Pow(ellipse.r1 * Math.Sin(radians), 2));
            //    double x = ellipse.x + r * Math.Cos(radians);
            //    double y = ellipse.y + r * Math.Sin(radians);
            //    DataPoint point = new DataPoint(x, y);
            //    ellipseSeries.Points.Add(point);
            //}

            //// Добавляем серию на элемент Chart
            //dialogForm2.chart1.Series.Add(ellipseSeries);




            // Создаем новый серию данных
            //DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            //Series series = new Series();
            //series.ChartType = SeriesChartType.Point;
            //series.MarkerSize = 1; // Задаем размер символа равным 1, чтобы не мешал отображению эллипса
            //series.MarkerStyle = MarkerStyle.None;

            //// Добавляем эллипс на элемент Chart
            //Random random = new Random();
            //Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //Graphics g = dialogForm2.chart1.CreateGraphics();
            //// Устанавливаем преобразование координат для смещения начала координат вниз
            //g.TranslateTransform(0, dialogForm2.chart1.Height);
            //g.FillEllipse(new SolidBrush(color), (float)(ellipse.x - ellipse.r1), (float)(ellipse.y - ellipse.r2), (float)(2 * ellipse.r1), (float)(2 * ellipse.r2));
            //g.DrawEllipse(Pens.Black, (float)(ellipse.x - ellipse.r1), (float)(ellipse.y - ellipse.r2), (float)(2 * ellipse.r1), (float)(2 * ellipse.r2));
            //g.Dispose();




            DialogForm2 dialogForm2 = this.Owner as DialogForm2;
            Bitmap bitmap = new Bitmap(dialogForm2.chart1.Width, dialogForm2.chart1.Height);

            // Создание объекта Graphics из Bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                // Устанавливаем преобразование координат для смещения начала координат вниз
                //g.TranslateTransform(0, dialogForm2.chart1.Height);
                graphics.FillEllipse(new SolidBrush(color), (float)(ellipse.x - ellipse.r1), (float)(ellipse.y - ellipse.r2), (float)(2 * ellipse.r1), (float)(2 * ellipse.r2));
                graphics.DrawEllipse(Pens.Black, (float)(ellipse.x - ellipse.r1), (float)(ellipse.y - ellipse.r2), (float)(2 * ellipse.r1), (float)(2 * ellipse.r2));

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
