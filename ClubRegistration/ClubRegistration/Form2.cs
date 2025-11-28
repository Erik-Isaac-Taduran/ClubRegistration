using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class Form2 : Form
    {
        private List<Student> students;
        private DataTable dataTable;

        public Form2(List<Student> studentList, DataTable dt)
        {
            InitializeComponent();
            students = studentList;
            dataTable = dt;
            LoadStudentIDs();
        }

        private void LoadStudentIDs()
        {
            comboBox4.Items.Clear();
            foreach (var s in students)
            {
                comboBox4.Items.Add(s.StudentId);
            }
            if (comboBox4.Items.Count > 0)
                comboBox4.SelectedIndex = 0;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null) return;

            long selectedId = Convert.ToInt64(comboBox4.SelectedItem);
            Student student = students.FirstOrDefault(s => s.StudentId == selectedId);

            if (student != null)
            {
                textBox3.Text = student.FirstName;     // First Name
                textBox4.Text = student.MiddleName;    // Middle
                textBox2.Text = student.LastName;      // Last
                textBox5.Text = student.Age.ToString(); // Age
                comboBox2.Text = student.Gender;       // Gender
                comboBox1.Text = student.Program;      // Program
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            long selectedId = Convert.ToInt64(comboBox4.SelectedItem);
            Student student = students.FirstOrDefault(s => s.StudentId == selectedId);

            if (student != null)
            {
                student.FirstName = textBox3.Text;
                student.MiddleName = textBox4.Text;
                student.LastName = textBox2.Text;
                student.Age = int.Parse(textBox5.Text);
                student.Gender = comboBox2.Text;
                student.Program = comboBox1.Text;

                
                dataTable.Rows.Clear();
                foreach (var s in students)
                {
                    dataTable.Rows.Add(s.StudentId, s.FirstName, s.MiddleName, s.LastName, s.Age, s.Gender, s.Program);
                }

                MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}