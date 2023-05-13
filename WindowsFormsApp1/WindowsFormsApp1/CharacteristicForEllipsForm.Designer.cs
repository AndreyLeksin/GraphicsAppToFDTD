﻿
namespace WindowsFormsApp1
{
    partial class CharacteristicForEllipsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CoordinateYtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CoordinateXtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FocalDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.r2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.r1TextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveObjectBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 100);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(919, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Характеристика для эллипса";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CoordinateYtextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CoordinateXtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FocalDistanceTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.r2TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.r1TextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(165, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 257);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Y";
            // 
            // CoordinateYtextBox
            // 
            this.CoordinateYtextBox.Location = new System.Drawing.Point(467, 208);
            this.CoordinateYtextBox.Name = "CoordinateYtextBox";
            this.CoordinateYtextBox.Size = new System.Drawing.Size(64, 34);
            this.CoordinateYtextBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 29);
            this.label7.TabIndex = 31;
            this.label7.Text = "X";
            // 
            // CoordinateXtextBox
            // 
            this.CoordinateXtextBox.Location = new System.Drawing.Point(355, 208);
            this.CoordinateXtextBox.Name = "CoordinateXtextBox";
            this.CoordinateXtextBox.Size = new System.Drawing.Size(64, 34);
            this.CoordinateXtextBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Фокальное расстояние:";
            // 
            // FocalDistanceTextBox
            // 
            this.FocalDistanceTextBox.Location = new System.Drawing.Point(354, 154);
            this.FocalDistanceTextBox.Name = "FocalDistanceTextBox";
            this.FocalDistanceTextBox.Size = new System.Drawing.Size(109, 34);
            this.FocalDistanceTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Малая полуось:";
            // 
            // r2TextBox
            // 
            this.r2TextBox.Location = new System.Drawing.Point(354, 99);
            this.r2TextBox.Name = "r2TextBox";
            this.r2TextBox.Size = new System.Drawing.Size(109, 34);
            this.r2TextBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Большая полуось:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Точка привязки:";
            // 
            // r1TextBox
            // 
            this.r1TextBox.Location = new System.Drawing.Point(354, 45);
            this.r1TextBox.Name = "r1TextBox";
            this.r1TextBox.Size = new System.Drawing.Size(109, 34);
            this.r1TextBox.TabIndex = 21;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(453, 436);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(175, 53);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // SaveObjectBtn
            // 
            this.SaveObjectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveObjectBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveObjectBtn.FlatAppearance.BorderSize = 0;
            this.SaveObjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveObjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveObjectBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveObjectBtn.Location = new System.Drawing.Point(272, 436);
            this.SaveObjectBtn.Name = "SaveObjectBtn";
            this.SaveObjectBtn.Size = new System.Drawing.Size(175, 53);
            this.SaveObjectBtn.TabIndex = 36;
            this.SaveObjectBtn.Text = "Сохранить";
            this.SaveObjectBtn.UseVisualStyleBackColor = false;
            this.SaveObjectBtn.Click += new System.EventHandler(this.SaveObjectBtn_Click);
            // 
            // CharacteristicForEllipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(919, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveObjectBtn);
            this.Name = "CharacteristicForEllipsForm";
            this.Text = "Характеристика для эллипса";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox r1TextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveObjectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox FocalDistanceTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox r2TextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CoordinateYtextBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox CoordinateXtextBox;
    }
}