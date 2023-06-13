
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.reset = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.RoleLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfPmlLayersTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SimulationTimeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpatialGridStepTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.Loginlabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EzCheckBox = new System.Windows.Forms.CheckBox();
            this.HyCheckBox = new System.Windows.Forms.CheckBox();
            this.HxCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(418, 717);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(200, 50);
            this.reset.TabIndex = 31;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(418, 661);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(200, 50);
            this.calculate.TabIndex = 29;
            this.calculate.Text = "Рассчитать";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-10, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2027, 5);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.RoleLabel2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(1598, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 38);
            this.panel2.TabIndex = 22;
            // 
            // RoleLabel2
            // 
            this.RoleLabel2.AutoSize = true;
            this.RoleLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.RoleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel2.ForeColor = System.Drawing.Color.White;
            this.RoleLabel2.Location = new System.Drawing.Point(193, 0);
            this.RoleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel2.Name = "RoleLabel2";
            this.RoleLabel2.Size = new System.Drawing.Size(85, 32);
            this.RoleLabel2.TabIndex = 0;
            this.RoleLabel2.Text = "Роль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество слоев PML:";
            // 
            // NumberOfPmlLayersTextBox
            // 
            this.NumberOfPmlLayersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPmlLayersTextBox.Location = new System.Drawing.Point(479, 241);
            this.NumberOfPmlLayersTextBox.Name = "NumberOfPmlLayersTextBox";
            this.NumberOfPmlLayersTextBox.Size = new System.Drawing.Size(249, 30);
            this.NumberOfPmlLayersTextBox.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.HeightTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.WidthtextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SimulationTimeTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.SpatialGridStepTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.NumberOfPmlLayersTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 376);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Высота";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTextBox.Location = new System.Drawing.Point(532, 101);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(196, 30);
            this.HeightTextBox.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ширина";
            // 
            // WidthtextBox
            // 
            this.WidthtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthtextBox.Location = new System.Drawing.Point(532, 54);
            this.WidthtextBox.Name = "WidthtextBox";
            this.WidthtextBox.ReadOnly = true;
            this.WidthtextBox.Size = new System.Drawing.Size(196, 30);
            this.WidthtextBox.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Время моделирования:";
            // 
            // SimulationTimeTextBox
            // 
            this.SimulationTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimulationTimeTextBox.Location = new System.Drawing.Point(479, 301);
            this.SimulationTimeTextBox.Name = "SimulationTimeTextBox";
            this.SimulationTimeTextBox.Size = new System.Drawing.Size(249, 30);
            this.SimulationTimeTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "шаг пространственной сетки:";
            // 
            // SpatialGridStepTextBox
            // 
            this.SpatialGridStepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpatialGridStepTextBox.Location = new System.Drawing.Point(479, 180);
            this.SpatialGridStepTextBox.Name = "SpatialGridStepTextBox";
            this.SpatialGridStepTextBox.Size = new System.Drawing.Size(249, 30);
            this.SpatialGridStepTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Размеры расчётной области в микрометрах:";
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.Loginlabel2);
            this.loginPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPanel.Location = new System.Drawing.Point(1598, 51);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(278, 38);
            this.loginPanel.TabIndex = 23;
            // 
            // Loginlabel2
            // 
            this.Loginlabel2.AutoSize = true;
            this.Loginlabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Loginlabel2.ForeColor = System.Drawing.Color.White;
            this.Loginlabel2.Location = new System.Drawing.Point(184, 0);
            this.Loginlabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loginlabel2.Name = "Loginlabel2";
            this.Loginlabel2.Size = new System.Drawing.Size(94, 32);
            this.Loginlabel2.TabIndex = 0;
            this.Loginlabel2.Text = "Логин";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.chart3);
            this.groupBox2.Controls.Add(this.chart2);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(780, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1132, 791);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат эксперимента";
            // 
            // chart3
            // 
            chartArea10.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            legend10.Title = "Цвета графиков";
            legend10.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart3.Legends.Add(legend10);
            this.chart3.Location = new System.Drawing.Point(575, 33);
            this.chart3.Name = "chart3";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "-";
            series10.Name = "Series1";
            this.chart3.Series.Add(series10);
            this.chart3.Size = new System.Drawing.Size(551, 383);
            this.chart3.TabIndex = 15;
            this.chart3.Text = "chart3";
            title10.Name = "Диаграмма";
            title10.Text = "График функций";
            this.chart3.Titles.Add(title10);
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            legend11.Title = "Цвета графиков";
            legend11.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(293, 434);
            this.chart2.Name = "chart2";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.LegendText = "-";
            series11.Name = "Series1";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(551, 341);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            title11.Name = "Диаграмма";
            title11.Text = "График функций";
            this.chart2.Titles.Add(title11);
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            legend12.Title = "Цвета графиков";
            legend12.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(7, 33);
            this.chart1.Name = "chart1";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Color = System.Drawing.Color.Red;
            series12.Legend = "Legend1";
            series12.LegendText = "-";
            series12.Name = "Series1";
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(551, 383);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title12.Name = "Диаграмма";
            title12.Text = "График функций";
            this.chart1.Titles.Add(title12);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EzCheckBox);
            this.groupBox4.Controls.Add(this.HyCheckBox);
            this.groupBox4.Controls.Add(this.HxCheckBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(17, 560);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 286);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите графики";
            // 
            // EzCheckBox
            // 
            this.EzCheckBox.AutoSize = true;
            this.EzCheckBox.Location = new System.Drawing.Point(61, 195);
            this.EzCheckBox.Name = "EzCheckBox";
            this.EzCheckBox.Size = new System.Drawing.Size(140, 33);
            this.EzCheckBox.TabIndex = 2;
            this.EzCheckBox.Text = "График 3";
            this.EzCheckBox.UseVisualStyleBackColor = true;
            // 
            // HyCheckBox
            // 
            this.HyCheckBox.AutoSize = true;
            this.HyCheckBox.Location = new System.Drawing.Point(61, 137);
            this.HyCheckBox.Name = "HyCheckBox";
            this.HyCheckBox.Size = new System.Drawing.Size(140, 33);
            this.HyCheckBox.TabIndex = 1;
            this.HyCheckBox.Text = "График 2";
            this.HyCheckBox.UseVisualStyleBackColor = true;
            // 
            // HxCheckBox
            // 
            this.HxCheckBox.AutoSize = true;
            this.HxCheckBox.Location = new System.Drawing.Point(61, 79);
            this.HxCheckBox.Name = "HxCheckBox";
            this.HxCheckBox.Size = new System.Drawing.Size(140, 33);
            this.HxCheckBox.TabIndex = 0;
            this.HxCheckBox.Text = "График 1";
            this.HxCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1017);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Эксперимент";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RoleLabel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NumberOfPmlLayersTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label Loginlabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox SimulationTimeTextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox SpatialGridStepTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox EzCheckBox;
        private System.Windows.Forms.CheckBox HyCheckBox;
        private System.Windows.Forms.CheckBox HxCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox WidthtextBox;
    }
}

