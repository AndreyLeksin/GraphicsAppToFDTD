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
    public partial class DialogForm2 : Form
    {
        private readonly CheckUser _user;
        public DialogForm2(CheckUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
        }

        //Публичное свойство для доступа к List
        public List<Figure> Figures { get; } = new List<Figure>();

        private void OpenForm3Btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_user);
            form1.Owner = this;
            form1.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //DialogForm1 dialogForm1 = new DialogForm1();
            this.Hide();
            //dialogForm1.ShowDialog();
            this.Close();
        }

        //настройка переноса строки в listbox
        private void BoxForObjectListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(BoxForObjectListBox.Items[e.Index].ToString(),
                BoxForObjectListBox.Font, BoxForObjectListBox.Width).Height;
        }
        //настройка переноса строки в listbox
        private void BoxForObjectListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (BoxForObjectListBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(BoxForObjectListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        //настройка переноса строки в listbox
        private void BoxForSourceListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(BoxForSourceListBox.Items[e.Index].ToString(),
                BoxForSourceListBox.Font, BoxForSourceListBox.Width).Height;
        }
        //настройка переноса строки в listbox
        private void BoxForSourceListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (BoxForSourceListBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(BoxForSourceListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void AddObjectBtn_Click(object sender, EventArgs e)
        {
            if (ObjectComboBox.SelectedIndex > -1)
            {
                if (ObjectComboBox.SelectedItem.ToString() == "Прямоугольник")
                {
                    string selectValue = ObjectComboBox.SelectedItem.ToString();
                    DialogForm3 dialogForm3 = new DialogForm3(selectValue);
                    dialogForm3.Owner = this;
                    dialogForm3.ShowDialog();
                }
                else
                {
                    string selectValue = ObjectComboBox.SelectedItem.ToString();
                    CharacteristicForEllipsForm characteristicForEllipsForm = new CharacteristicForEllipsForm(selectValue);
                    characteristicForEllipsForm.Owner = this;
                    characteristicForEllipsForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("ВЫберите объекты из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AddCharacteristicsBtn_Click(object sender, EventArgs e)
        {
            if (SourceComboBox.SelectedIndex > -1)
            {
                if (SourceComboBox.SelectedItem.ToString() == "Точечные")
                {
                    string selectValue = SourceComboBox.SelectedItem.ToString();
                    CharacteristicForSourceForm characteristicForSourceForm = new CharacteristicForSourceForm(selectValue);
                    characteristicForSourceForm.Owner = this;
                    characteristicForSourceForm.ShowDialog();
                }
                else
                {
                    string selectValue = SourceComboBox.SelectedItem.ToString();
                    CharacteristicForSourceForm characteristicForSourceForm2 = new CharacteristicForSourceForm(selectValue);
                    characteristicForSourceForm2.Owner = this;
                    characteristicForSourceForm2.ShowDialog();
                }
            }
            else
                MessageBox.Show("ВЫберите источник из списка!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearObjectBtn_Click(object sender, EventArgs e)
        {
            if (BoxForObjectListBox.SelectedIndex != -1)
                BoxForObjectListBox.Items.RemoveAt(BoxForObjectListBox.SelectedIndex);
        }

        private void ClearSourceBtn_Click(object sender, EventArgs e)
        {
            if (BoxForSourceListBox.SelectedIndex != -1)
                BoxForSourceListBox.Items.RemoveAt(BoxForSourceListBox.SelectedIndex);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            DialogForm3 dialogForm3 = this.Owner as DialogForm3;
            if (BoxForObjectListBox.SelectedIndex > 0)
            {
                // Меняем порядок элементов в коллекции Figures
                var selectedFigure = Figures[BoxForObjectListBox.SelectedIndex];
                Figures.RemoveAt(BoxForObjectListBox.SelectedIndex);
                Figures.Insert(BoxForObjectListBox.SelectedIndex - 1, selectedFigure);

                // Меняем порядок элементов в ListBox
                var selectedIndex = BoxForObjectListBox.SelectedIndex;
                var selectedText = BoxForObjectListBox.SelectedItem.ToString();
                BoxForObjectListBox.Items.RemoveAt(selectedIndex);
                BoxForObjectListBox.Items.Insert(selectedIndex - 1, selectedText);
                BoxForObjectListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            DialogForm3 dialogForm3 = this.Owner as DialogForm3;
            if (BoxForObjectListBox.SelectedIndex < BoxForObjectListBox.Items.Count - 1)
            {
                // Меняем порядок элементов в коллекции Figures
                var selectedFigure = Figures[BoxForObjectListBox.SelectedIndex];
                Figures.RemoveAt(BoxForObjectListBox.SelectedIndex);
                Figures.Insert(BoxForObjectListBox.SelectedIndex + 1, selectedFigure);

                // Меняем порядок элементов в ListBox
                var selectedIndex = BoxForObjectListBox.SelectedIndex;
                var selectedText = BoxForObjectListBox.SelectedItem.ToString();
                BoxForObjectListBox.Items.RemoveAt(selectedIndex);
                BoxForObjectListBox.Items.Insert(selectedIndex + 1, selectedText);
                BoxForObjectListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        private void ShowFigureBtn_Click(object sender, EventArgs e)
        {
            //if (BoxForObjectListBox.Items.Count != 0)
            //{
            //    chart1.Series.Clear();
            //    foreach (Figure figure in Figures)
            //    {
            //        Series series = new Series();
            //        series.ChartType = SeriesChartType.Point;
            //        series.MarkerSize = (int)Math.Max(figure.x, figure.y); // задаем размер символа

            //        if (figure is WindowsFormsApp1.Rectanglee rectangle) //проверка типа каждого элемента списка 
            //            series.MarkerStyle = MarkerStyle.Square;
            //        else
            //            series.MarkerStyle = MarkerStyle.Circle;

            //        // Добавляем точку на элемент Chart
            //        series.Points.AddXY(figure.x, figure.y);
            //        // Добавляем серию на элемент Chart
            //        chart1.Series.Add(series);
            //    }
            //}
            //else
            //    MessageBox.Show("Нужно добавить объекты!");

            

            try
            {
                int width = int.Parse(WidthtextBox.Text);
                int height = int.Parse(HeightTextBox.Text);
                // Создание объекта Bitmap для рисования графика
                Bitmap bitmap = new Bitmap(width, height);
                
                if (BoxForObjectListBox.Items.Count != 0 && BoxForSourceListBox.Items.Count != 0)
                {
                    foreach (Figure figure in Figures)
                    {
                        if (figure is WindowsFormsApp1.Rectanglee rectangle) //проверка типа каждого элемента списка 
                        {
                            // Создание объекта Graphics из Bitmap
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                // Получаем координаты вершин прямоугольника
                                double left = ((Rectanglee)figure).BottomLeftPoint.X;
                                double top = ((Rectanglee)figure).BottomLeftPoint.Y;
                                double right = ((Rectanglee)figure).BottomLeftPoint.X + ((Rectanglee)figure).Width;
                                double bottom = ((Rectanglee)figure).BottomLeftPoint.Y - ((Rectanglee)figure).Height;

                                Random random = new Random();
                                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                                // Заливка прямоугольника цветом
                                graphics.FillRectangle(new SolidBrush(color), (float)left, (float)bottom, (float)((Rectanglee)figure).Width,
                                    (float)((Rectanglee)figure).Height);

                                // Рисование границы прямоугольника
                                graphics.DrawRectangle(Pens.Black, (float)left, (float)bottom, (float)((Rectanglee)figure).Width,
                                    (float)((Rectanglee)figure).Height);

                                // Отобразить графический объект на элементе управления Chart
                                chart1.CreateGraphics().DrawImage(bitmap, 0, 0);

                            }
                        }
                        else
                        {
                            // Создание объекта Graphics из Bitmap
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                Random random = new Random();
                                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                                // Заливка эллипса цветом
                                graphics.FillEllipse(new SolidBrush(color), (float)(((Ellipse)figure).x - ((Ellipse)figure).r1),
                                    (float)(((Ellipse)figure).y - ((Ellipse)figure).r2), (float)(2 * ((Ellipse)figure).r1),
                                    (float)(2 * ((Ellipse)figure).r2));
                                // Рисование границы эллипса
                                graphics.DrawEllipse(Pens.Black, (float)(((Ellipse)figure).x - ((Ellipse)figure).r1),
                                    (float)(((Ellipse)figure).y - ((Ellipse)figure).r2), (float)(2 * ((Ellipse)figure).r1),
                                    (float)(2 * ((Ellipse)figure).r2));

                                // Отобразить графический объект на элементе управления Chart
                                chart1.CreateGraphics().DrawImage(bitmap, 0, 0);

                            }
                        }

                    }

                    //выделение границы расчетной области цветной линией
                    // Создание объекта Graphics из Bitmap
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        // Получаем координаты вершин расчетной области
                        int leftBound = 0;
                        int topBound = 0;
                        int rightBound = width - 1;
                        int bottomBound = height - 1;

                        // Задаем цвет и ширину для границы расчетной области
                        Color borderColor = Color.Black; // Здесь можно выбрать желаемый цвет
                        int borderWidth = 4; // Здесь можно выбрать желаемую ширину

                        // Заливка границы расчетной области цветом
                        graphics.FillRectangle(new SolidBrush(borderColor), leftBound, topBound, borderWidth, height); // Левая граница
                        graphics.FillRectangle(new SolidBrush(borderColor), rightBound - borderWidth + 1, topBound, borderWidth, height); // Правая граница
                        graphics.FillRectangle(new SolidBrush(borderColor), leftBound, topBound, width, borderWidth); // Верхняя граница
                        graphics.FillRectangle(new SolidBrush(borderColor), leftBound, bottomBound - borderWidth + 1, width, borderWidth); // Нижняя граница

                        // Если нужно, также можно нарисовать границу расчетной области
                        //graphics.DrawRectangle(new Pen(borderColor, borderWidth), leftBound, topBound, width, height);

                        // Вывести графический объект на элемент управления Chart
                        chart1.CreateGraphics().DrawImage(bitmap, 0, 0);

                    }
                    // Отображение звезды на графике с использованием полученных координат
                    // Получение координат из формы с характеристиками для источника
                    double xCoordinate = CharacteristicForSourceForm.XCoordinate;
                    double yCoordinate = CharacteristicForSourceForm.YCoordinate;

                    // Создание объекта Graphics из Bitmap
                    Bitmap bitmap2 = new Bitmap(chart1.Width, chart1.Height);
                    using (Graphics graphics = Graphics.FromImage(bitmap2))
                    {
                        // Отображение символа '*' на графике
                        float starSize = 50; // Размер символа
                        float starX = (float)xCoordinate - starSize / 2; // Координата x символа
                        float starY = (float)yCoordinate - starSize / 2; // Координата y символа

                        // Создание шрифта для символа
                        Font starFont = new Font("Arial", starSize, FontStyle.Regular);

                        // Отображение символа '*' на графике
                        graphics.DrawString("*", starFont, Brushes.Red, new PointF(starX, starY));

                        // Отобразить графический объект на элементе управления Chart
                        chart1.CreateGraphics().DrawImage(bitmap2, 0, 0);
                    }
                }
                else if(BoxForObjectListBox.Items.Count == 0)
                    MessageBox.Show("Нужно добавить объекты!");
                else
                    MessageBox.Show("Нужно добавить точечный источник!");
            }
            catch
            {
                MessageBox.Show("Введите размеры расчетной области!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chart1_Paint(object sender, PaintEventArgs e)
        {
            // Создание объекта Graphics из PaintEventArgs
            Graphics graphics = e.Graphics;

            // Рисование сетки по оси X
            for (int x = 0; x <= chart1.Width; x += 50) // Интервал между линиями сетки по оси X
            {
                graphics.DrawLine(Pens.LightGray, x, 0, x, chart1.Height);
                graphics.DrawString(x.ToString(), Font, Brushes.Black, x, chart1.Height - 20);
            }
            // Рисование сетки по оси Y
            for (int y = 0; y <= chart1.Height; y += 50) // Интервал между линиями сетки по оси Y
            {
                graphics.DrawLine(Pens.LightGray, 0, y, chart1.Width, y);
                graphics.DrawString(y.ToString(), Font, Brushes.Black, 5, y);
            }
        }

        
    }
}
