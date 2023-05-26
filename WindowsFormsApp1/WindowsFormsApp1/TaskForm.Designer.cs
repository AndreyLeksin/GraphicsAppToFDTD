﻿
namespace WindowsFormsApp1
{
    partial class TaskForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CloseTaskBtn = new System.Windows.Forms.Button();
            this.OpenTaskBtn = new System.Windows.Forms.Button();
            this.DeleteTaskBtn = new System.Windows.Forms.Button();
            this.CreateTaskBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseTaskBtn
            // 
            this.CloseTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseTaskBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.CloseTaskBtn.FlatAppearance.BorderSize = 0;
            this.CloseTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseTaskBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseTaskBtn.Location = new System.Drawing.Point(731, 799);
            this.CloseTaskBtn.Name = "CloseTaskBtn";
            this.CloseTaskBtn.Size = new System.Drawing.Size(300, 60);
            this.CloseTaskBtn.TabIndex = 12;
            this.CloseTaskBtn.Text = "Закрыть задачу";
            this.CloseTaskBtn.UseVisualStyleBackColor = false;
            this.CloseTaskBtn.Click += new System.EventHandler(this.CloseTaskBtn_Click);
            // 
            // OpenTaskBtn
            // 
            this.OpenTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenTaskBtn.BackColor = System.Drawing.Color.Lime;
            this.OpenTaskBtn.FlatAppearance.BorderSize = 0;
            this.OpenTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenTaskBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenTaskBtn.Location = new System.Drawing.Point(372, 799);
            this.OpenTaskBtn.Name = "OpenTaskBtn";
            this.OpenTaskBtn.Size = new System.Drawing.Size(300, 60);
            this.OpenTaskBtn.TabIndex = 11;
            this.OpenTaskBtn.Text = "Открыть задачу";
            this.OpenTaskBtn.UseVisualStyleBackColor = false;
            this.OpenTaskBtn.Click += new System.EventHandler(this.OpenTaskBtn_Click);
            // 
            // DeleteTaskBtn
            // 
            this.DeleteTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteTaskBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteTaskBtn.FlatAppearance.BorderSize = 0;
            this.DeleteTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTaskBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteTaskBtn.Location = new System.Drawing.Point(1088, 799);
            this.DeleteTaskBtn.Name = "DeleteTaskBtn";
            this.DeleteTaskBtn.Size = new System.Drawing.Size(300, 60);
            this.DeleteTaskBtn.TabIndex = 10;
            this.DeleteTaskBtn.Text = "Удалить задачу";
            this.DeleteTaskBtn.UseVisualStyleBackColor = false;
            this.DeleteTaskBtn.Click += new System.EventHandler(this.DeleteTaskBtn_Click);
            // 
            // CreateTaskBtn
            // 
            this.CreateTaskBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateTaskBtn.BackColor = System.Drawing.Color.Yellow;
            this.CreateTaskBtn.FlatAppearance.BorderSize = 0;
            this.CreateTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTaskBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateTaskBtn.Location = new System.Drawing.Point(1417, 156);
            this.CreateTaskBtn.Name = "CreateTaskBtn";
            this.CreateTaskBtn.Size = new System.Drawing.Size(350, 60);
            this.CreateTaskBtn.TabIndex = 9;
            this.CreateTaskBtn.Text = "Создать задачу";
            this.CreateTaskBtn.UseVisualStyleBackColor = false;
            this.CreateTaskBtn.Click += new System.EventHandler(this.CreateTaskBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Таблица с задачами";
            // 
            // TaskDataGridView
            // 
            this.TaskDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView.Location = new System.Drawing.Point(12, 230);
            this.TaskDataGridView.Name = "TaskDataGridView";
            this.TaskDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TaskDataGridView.RowTemplate.Height = 24;
            this.TaskDataGridView.Size = new System.Drawing.Size(1755, 544);
            this.TaskDataGridView.TabIndex = 7;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1779, 1042);
            this.Controls.Add(this.CloseTaskBtn);
            this.Controls.Add(this.OpenTaskBtn);
            this.Controls.Add(this.DeleteTaskBtn);
            this.Controls.Add(this.CreateTaskBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.Text = "Задачи для студентов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseTaskBtn;
        private System.Windows.Forms.Button OpenTaskBtn;
        private System.Windows.Forms.Button DeleteTaskBtn;
        private System.Windows.Forms.Button CreateTaskBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView TaskDataGridView;
    }
}