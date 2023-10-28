using Project.Logics;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project.Models.StudentInfor;

namespace Project
{
    public partial class Form2 : Form
    {
        StudentServices studentServices = new StudentServices();
        ClassServices classServices = new ClassServices();
        ScoreServices scoreServices = new ScoreServices();
        SubjectServices subjectServices = new SubjectServices();
        public Form2()
        {
            InitializeComponent();
            var studentID = studentServices.GetStudentIds();
            var studentDictionary = new Dictionary<int, string>();
            studentDictionary.Add(0, "All");
            foreach (var studentId in studentID)
            {
                studentDictionary.Add(studentId, studentId.ToString());
            }

            cbStudent.DataSource = new BindingSource(studentDictionary, null);
            cbStudent.ValueMember = "Key";
            cbStudent.DisplayMember = "Value";
            LoadForDGV();
        }
        private void LoadForDGV()
        {
            var selectedValue = (KeyValuePair<int, string>)cbStudent.SelectedItem;
            int selectedStudentId = selectedValue.Key;

            if (selectedStudentId == 0)
            {
                List<Student> students = studentServices.GetStudents();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("StudentId", "Student ID");
                dataGridView1.Columns.Add("StudentName", "Student Name");
                dataGridView1.Columns.Add("Sex", "Sex");
                dataGridView1.Columns.Add("DOB", "DOB");
                dataGridView1.Columns["StudentId"].DataPropertyName = "StudentId";
                dataGridView1.Columns["StudentName"].DataPropertyName = "StudentName";
                dataGridView1.Columns["Sex"].DataPropertyName = "Sex";
                dataGridView1.Columns["DOB"].DataPropertyName = "DOB";
                dataGridView1.DataSource = students;
            }
            else
            {
                Student student = studentServices.GetStudentByStudentId(selectedStudentId);
                List<Student> studentList = new List<Student> { student };
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("StudentId", "Student ID");
                dataGridView1.Columns.Add("StudentName", "Student Name");
                dataGridView1.Columns.Add("Sex", "Sex");
                dataGridView1.Columns.Add("DOB", "DOB");
                dataGridView1.Columns["StudentId"].DataPropertyName = "StudentId";
                dataGridView1.Columns["StudentName"].DataPropertyName = "StudentName";
                dataGridView1.Columns["Sex"].DataPropertyName = "Sex";
                dataGridView1.Columns["DOB"].DataPropertyName = "DOB";
                dataGridView1.DataSource = studentList;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadForDGV();
            var selectedValue = (KeyValuePair<int, string>)cbStudent.SelectedItem;
            int selectedStudentId = selectedValue.Key;

            if (selectedStudentId != 0)
            {
                Student student = studentServices.GetStudentByStudentId(selectedStudentId);
                studentName.Text = student.StudentName;
                dateTimePicker1.Value = student.Dob ?? DateTime.Now;
                if (student.Sex == "Male")
                {
                    maleRadioButton.Checked = true;
                }
                else if (student.Sex == "Female")
                {
                    femaleRadioButton.Checked = true;
                }

            }
        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
