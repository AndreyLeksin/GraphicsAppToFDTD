using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CharacteristicForSourceForm : Form
    {
        private string _selectValue;
        public CharacteristicForSourceForm(string selectValue)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _selectValue = selectValue;
        }

        public static double XCoordinate { get; private set; }
        public static double YCoordinate { get; private set; }

        private void SaveSourceBtn_Click(object sender, EventArgs e)
        {
            DialogForm2 dialogForm2 = this.Owner as DialogForm2;

            double amplitude = double.Parse(AmplitudeTextBox.Text);
            double periodicity = double.Parse(PeriodicityTextBox.Text);
            double CoordinateX = double.Parse(CoordinateXtextBox.Text);
            double CoordinateY = double.Parse(CoordinateYtextBox.Text);

            XCoordinate = double.Parse(CoordinateXtextBox.Text);
            YCoordinate = double.Parse(CoordinateYtextBox.Text);

            if (dialogForm2 != null)
                dialogForm2.BoxForSourceListBox.Items.Add(string.Format("{0}: Амплитуда: {1}, Частота: {2}, " +
                        "Координаты: x = {3} y = {4}", _selectValue, amplitude, periodicity, CoordinateX, CoordinateY));
            this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отменить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
