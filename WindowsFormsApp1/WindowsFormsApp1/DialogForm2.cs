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
using System.Windows.Forms.DataVisualization.Charting;

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

        private void AddCharacteristicsBtn_Click(object sender, EventArgs e)
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

        //Публичное свойство для доступа к List
        public List<Figure> Figures { get; } = new List<Figure>();

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
    }
}
