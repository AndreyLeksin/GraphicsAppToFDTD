﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DataBaseForm : Form
    {
        DB db = new DB();
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void CreateColumn()
        {
            StudentsdataGridView.Columns.Add("ID_Student", "ID");
            StudentsdataGridView.Columns.Add("Title_Group", "Название группы");
            StudentsdataGridView.Columns.Add("Surname", "Фамилия");
            StudentsdataGridView.Columns.Add("Name", "Имя");
            StudentsdataGridView.Columns.Add("Patronymic", "Отчество");
            StudentsdataGridView.Columns.Add("Email", "Email");
        }

        private void CreateColumnTeacher()
        {
            TeacherDataGridView.Columns.Add("ID_Teacher", "ID");
            TeacherDataGridView.Columns.Add("Surname", "Фамилия");
            TeacherDataGridView.Columns.Add("Name", "Имя");
            TeacherDataGridView.Columns.Add("Patronymic", "Отчество");
            TeacherDataGridView.Columns.Add("Email", "Email");
            TeacherDataGridView.Columns.Add("Contact_Number", "Контактный номер");
        }

        private void CreateColumnTask()
        {
            TaskDataGridView.Columns.Add("ID_Task", "№ задачи");
            TaskDataGridView.Columns.Add("Surname", "Фамилия");
            TaskDataGridView.Columns.Add("Name", "Имя");
            TaskDataGridView.Columns.Add("Patronymic", "Отчество");
            TaskDataGridView.Columns.Add("Title_Task", "Название задания");
            TaskDataGridView.Columns.Add("Content", "Описание задания");

        }

        private void CreateColumnGroups()
        {
            GroupsDataGridView.Columns.Add("ID_Group", "ID");
            GroupsDataGridView.Columns.Add("Title_Group", "Название группы");

        }

        public void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"SELECT S.ID_Student, G.Title_Group, S.Surname, S.Name, S.Patronymic, S.Email FROM Student S, [Group] G " +
                $"WHERE S.ID_Group = G.ID_Group";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));

            reader.Close();
            db.closeConnection();
        }

        public void RefreshDataGridTeacher(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"SELECT ID_Teacher, Surname, Name, Patronymic, Email, Contact_Number FROM Teacher";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), 
                    reader.GetString(5));

            reader.Close();
            db.closeConnection();
        }

        public void RefreshDataGridTask(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"SELECT ID_Task, S.Surname, S.Name, S.Patronymic, Title_Task, Content FROM Individual_Task, Student S " +
                    $"WHERE S.ID_Student = Student_ID";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));

            reader.Close();
            db.closeConnection();
        }

        public void RefreshDataGridGroups(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string query = $"SELECT ID_Group, Title_Group FROM [Group]";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                dgv.Rows.Add(reader.GetInt32(0), reader.GetString(1));

            reader.Close();
            db.closeConnection();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[1].Parent = null;
            CreateColumn();
            RefreshDataGrid(StudentsdataGridView);
            CreateColumnTeacher();
            RefreshDataGridTeacher(TeacherDataGridView);
            CreateColumnTask();
            RefreshDataGridTask(TaskDataGridView);
            CreateColumnGroups();
            RefreshDataGridGroups(GroupsDataGridView);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            StudentsdataGridView.Rows.Clear();
            string query = $"SELECT S.ID_Student, G.Title_Group, S.Surname, S.Name, S.Patronymic, S.Email FROM Student S, [Group] G " +
                $"WHERE S.ID_Group = G.ID_Group AND CONCAT(G.Title_Group, S.Surname, S.Name, S.Patronymic, S.Email) LIKE '%" + SearchTextBox.Text + "%'";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                StudentsdataGridView.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));

            reader.Close();
            db.closeConnection();
        }

        private void SearchTeacherTextBox2_TextChanged(object sender, EventArgs e)
        {
            TeacherDataGridView.Rows.Clear();
            string query = $"SELECT Surname, Name, Patronymic, Email, Contact_Number FROM Teacher WHERE CONCAT(Surname, Name, Patronymic, Email, Contact_Number) LIKE '%" + SearchTeacherTextBox2.Text + "%'";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                TeacherDataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));

            reader.Close();
            db.closeConnection();
        }

        private void SearchTaskTextBox_TextChanged(object sender, EventArgs e)
        {
            TaskDataGridView.Rows.Clear();
            string query = $"SELECT ID_Task, S.Surname, S.Name, S.Patronymic, Title_Task, Content FROM Individual_Task, Student S WHERE S.ID_Student = Student_ID AND CONCAT(ID_Task, S.Surname, S.Name, S.Patronymic, Title_Task, Content) LIKE '%" + SearchTaskTextBox.Text + "%'";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                TaskDataGridView.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));

            reader.Close();
            db.closeConnection();
        }

        private void SearchGroupsTextBox_TextChanged(object sender, EventArgs e)
        {
            GroupsDataGridView.Rows.Clear();
            string query = $"SELECT Title_Group FROM [Group] WHERE Title_Group LIKE '%" + SearchGroupsTextBox.Text + "%'";

            SqlCommand command = new SqlCommand(query, db.getconnection());
            db.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                GroupsDataGridView.Rows.Add(reader.GetString(0));

            reader.Close();
            db.closeConnection();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Owner = this;
            addStudent.ShowDialog();
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            IzmenenieStudentaForm izmenenieStudentaForm = new IzmenenieStudentaForm();
            izmenenieStudentaForm.Owner = this;
            izmenenieStudentaForm.ShowDialog();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            db.openConnection();


            var selectedRowIndex = StudentsdataGridView.CurrentCell.RowIndex;
            var id = StudentsdataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var group = StudentsdataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var surname = StudentsdataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var name = StudentsdataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var patronymic = StudentsdataGridView.Rows[selectedRowIndex].Cells[4].Value;
            var email = StudentsdataGridView.Rows[selectedRowIndex].Cells[5].Value;

            string query = $"DELETE FROM Student WHERE ID_Student = @id";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            command.Parameters.AddWithValue("id", id);
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            RefreshDataGrid(StudentsdataGridView);
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            addTeacherForm.Owner = this;
            addTeacherForm.ShowDialog();
        }

        private void UpdateTeacher_Click(object sender, EventArgs e)
        {
            IzmenenieTeacherForm izmenenieTeacherForm = new IzmenenieTeacherForm();
            izmenenieTeacherForm.Owner = this;
            izmenenieTeacherForm.ShowDialog();
        }

        private void DeleteTeacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            db.openConnection();


            var selectedRowIndex = TeacherDataGridView.CurrentCell.RowIndex;
            var id = TeacherDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var surname = TeacherDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var name = TeacherDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var patronymic = TeacherDataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var email = TeacherDataGridView.Rows[selectedRowIndex].Cells[4].Value;
            var conNumber = TeacherDataGridView.Rows[selectedRowIndex].Cells[5].Value;

            string query = $"DELETE FROM Teacher WHERE ID_Teacher = @id";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            command.Parameters.AddWithValue("id", id);
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            RefreshDataGridTeacher(TeacherDataGridView);
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.Owner = this;
            addTaskForm.ShowDialog();
        }

        private void UpdateTask_Click(object sender, EventArgs e)
        {
            IzmenenieTaskForm izmenenieTaskForm = new IzmenenieTaskForm();
            izmenenieTaskForm.Owner = this;
            izmenenieTaskForm.ShowDialog();
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            db.openConnection();


            var selectedRowIndex = TaskDataGridView.CurrentCell.RowIndex;
            var id = TaskDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var surname = TaskDataGridView.Rows[selectedRowIndex].Cells[1].Value;
            var name = TaskDataGridView.Rows[selectedRowIndex].Cells[2].Value;
            var patronymic = TaskDataGridView.Rows[selectedRowIndex].Cells[3].Value;
            var titleTask = TaskDataGridView.Rows[selectedRowIndex].Cells[4].Value;
            var content = TaskDataGridView.Rows[selectedRowIndex].Cells[5].Value;

            string query = $"DELETE FROM Individual_Task WHERE ID_Task = @id";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            command.Parameters.AddWithValue("id", id);
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            RefreshDataGridTask(TaskDataGridView);
        }

        private void AddGroup_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.Owner = this;
            addGroupForm.ShowDialog();
        }

        private void UpdateGroup_Click(object sender, EventArgs e)
        {
            IzmenenieGroupForm izmenenieGroupForm = new IzmenenieGroupForm();
            izmenenieGroupForm.Owner = this;
            izmenenieGroupForm.ShowDialog();
        }

        private void DeleteGroup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel) return;

            db.openConnection();

            var selectedRowIndex = GroupsDataGridView.CurrentCell.RowIndex;
            var id = GroupsDataGridView.Rows[selectedRowIndex].Cells[0].Value;
            var group = GroupsDataGridView.Rows[selectedRowIndex].Cells["Title_Group"].Value;

            string query = $"DELETE FROM [Group] WHERE ID_Group = @id";
            SqlCommand command = new SqlCommand(query, db.getconnection());
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            db.closeConnection();
            RefreshDataGridGroups(GroupsDataGridView);
        }
    }
}
