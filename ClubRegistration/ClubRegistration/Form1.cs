using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            SetupDataTable();
            RefreshGrid();
        }

        private void SetupDataTable()
        {
            dataTable.Columns.Add("StudentId", typeof(long));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("MiddleName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Program", typeof(string));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbox1.Text) ||
                string.IsNullOrWhiteSpace(textbox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new Student
            {
                StudentId = Convert.ToInt64(textbox1.Text),
                FirstName = textBox4.Text,
                MiddleName = textBox5.Text,
                LastName = textbox2.Text,
                Age = Convert.ToInt32(textBox3.Text),
                Gender = comboBox2.Text,
                Program = comboBox1.Text
            };

            students.Add(student);
            dataTable.Rows.Add(student.StudentId, student.FirstName, student.MiddleName,
                             student.LastName, student.Age, student.Gender, student.Program);

            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(students, dataTable);
            f2.ShowDialog();
            RefreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }

        private void ClearFields()
        {
            textbox1.Clear();
            textbox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void textbox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    public class Student
    {
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Program { get; set; }
    }
}