﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class DialogForm2 : Form
    {
        public DialogForm2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#1A2D37");
        }

        private void OpenForm3Btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogForm1 dialogForm1 = new DialogForm1();
            this.Hide();
            dialogForm1.ShowDialog();
            this.Close();
        }

        private void AddObjectBtn_Click(object sender, EventArgs e)
        {
            string selectValue = ObjectComboBox.SelectedItem.ToString();
            DialogForm3 dialogForm3 = new DialogForm3(selectValue);
            dialogForm3.ShowDialog();
        }

        private void AddCharacteristicsBtn_Click(object sender, EventArgs e)
        {
            string selectValue = SourceComboBox.SelectedItem.ToString();
            CharacteristicForSourceForm characteristicForSourceForm = new CharacteristicForSourceForm(selectValue);
            characteristicForSourceForm.ShowDialog();
            
        }
    }
}
