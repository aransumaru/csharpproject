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
        public string messageBoxForm = "";
        public Form2()
        {
            InitializeComponent();
            var studentID = studentServices.GetStudentIds();
            var studentDictionary = new Dictionary<int, string>();
            studentDictionary.Add(0, "All");
            foreach (var studentId in studentID)
            {
                var student = studentServices.GetStudentByStudentId(studentId);
                studentDictionary.Add(studentId, student.StudentName);
            }

            cbStudent.DataSource = new BindingSource(studentDictionary, null);
            cbStudent.ValueMember = "Key";
            cbStudent.DisplayMember = "Value";
            dateTimePicker1.Value = DateTime.Now;
            LoadForDGV();
        }
        private void LoadForDGV()
        {
            var selectedValue = (KeyValuePair<int, string>)cbStudent.SelectedItem;
            int selectedStudentId = selectedValue.Key;

            if (selectedStudentId == 0)
            {
                List<StudentInfo> studentsInfo = studentServices.GetListStudent();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("StudentId", "Student ID");
                dataGridView1.Columns.Add("StudentName", "Student Name");
                dataGridView1.Columns.Add("Sex", "Sex");
                dataGridView1.Columns.Add("DOB", "DOB");
                dataGridView1.Columns.Add("Class", "Class");
                dataGridView1.Columns.Add("Subject", "Subject");
                dataGridView1.Columns["StudentId"].DataPropertyName = "StudentId";
                dataGridView1.Columns["StudentName"].DataPropertyName = "StudentName";
                dataGridView1.Columns["Sex"].DataPropertyName = "Sex";
                dataGridView1.Columns["DOB"].DataPropertyName = "DOB";
                dataGridView1.Columns["Class"].DataPropertyName = "ClassName";
                dataGridView1.Columns["Subject"].DataPropertyName = "SubjectName";

                dataGridView1.DataSource = studentsInfo;

                studentName.Clear();

            }
            else
            {
                StudentInfo studentInfo = studentServices.GetStudentInfoByStudentId(selectedStudentId);
                List<StudentInfo> studentInfoList = new List<StudentInfo> { studentInfo };
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("StudentId", "Student ID");
                dataGridView1.Columns.Add("StudentName", "Student Name");
                dataGridView1.Columns.Add("Sex", "Sex");
                dataGridView1.Columns.Add("DOB", "DOB");
                dataGridView1.Columns.Add("Class", "Class");
                dataGridView1.Columns.Add("Subject", "Subject");
                dataGridView1.Columns["StudentId"].DataPropertyName = "StudentId";
                dataGridView1.Columns["StudentName"].DataPropertyName = "StudentName";
                dataGridView1.Columns["Sex"].DataPropertyName = "Sex";
                dataGridView1.Columns["DOB"].DataPropertyName = "DOB";
                dataGridView1.Columns["Class"].DataPropertyName = "ClassName";
                dataGridView1.Columns["Subject"].DataPropertyName = "SubjectName";
                dataGridView1.DataSource = studentInfoList;
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
                studentidText.Text = student.StudentId.ToString();
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
            else
            {
                RefreshDataField();
            }
        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var selectedValue = (KeyValuePair<int, string>)cbStudent.SelectedItem;
            int selectedStudentId = selectedValue.Key;

            if (selectedStudentId == 0)
            {
                if (string.IsNullOrWhiteSpace(studentName.Text) ||
                    dateTimePicker1.Value == DateTime.Now ||
                    (!maleRadioButton.Checked && !femaleRadioButton.Checked))
                {
                    messageBoxForm = "Please fill in all fields to add a new student)";
                    MessageBox.Show(messageBoxForm);
                }
                else
                {
                    Student student = new Student
                    {
                        StudentName = studentName.Text,
                        Dob = dateTimePicker1.Value,
                        Sex = maleRadioButton.Checked ? "Male" : "Female"
                    };

                    studentServices.AddStudent(student);
                    RefreshStudentComboBox();
                    LoadForDGV();
                }
            }
            else
            {
                messageBoxForm = "Student ID must be empty to add (choose 'All' option to be empty)";
                MessageBox.Show(messageBoxForm);
                RefreshDataField();
                LoadForDGV();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (cbStudent.SelectedIndex > 0)
            {
                int selectedStudentId = (int)cbStudent.SelectedValue;

                Student student = studentServices.GetStudentByStudentId(selectedStudentId);
                if (student != null)
                {
                    student.StudentName = studentName.Text;
                    student.Dob = dateTimePicker1.Value;
                    student.Sex = maleRadioButton.Checked ? "Male" : "Female";

                    studentServices.UpdateStudent(student);
                    RefreshStudentComboBox();
                    LoadForDGV();
                }
            }
            else
            {
                messageBoxForm = "Student must be choosen";
                MessageBox.Show(messageBoxForm);
                RefreshDataField();
                LoadForDGV();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            {
                if (cbStudent.SelectedIndex > 0)
                {
                    int selectedStudentId = (int)cbStudent.SelectedValue;
                    studentServices.DeleteStudent(selectedStudentId);
                    RefreshStudentComboBox();
                    LoadForDGV();
                }
                else
                {
                    messageBoxForm = "Student must be choosen";
                    MessageBox.Show(messageBoxForm);
                    RefreshDataField();
                    LoadForDGV();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataField();
            LoadForDGV();
        }

        private void studentidText_TextChanged(object sender, EventArgs e)
        {
            studentidText.Enabled = false;
        }
        private void RefreshStudentComboBox()
        {
            var studentID = studentServices.GetStudentIds();
            var studentDictionary = new Dictionary<int, string>();
            studentDictionary.Add(0, "All");
            foreach (var studentId in studentID)
            {
                var student = studentServices.GetStudentByStudentId(studentId);
                studentDictionary.Add(studentId, student.StudentName);
            }
            cbStudent.DataSource = new BindingSource(studentDictionary, null);
            cbStudent.ValueMember = "Key";
            cbStudent.DisplayMember = "Value";
        }
        private void RefreshDataField()
        {
            studentidText.Clear();
            studentName.Clear();
            dateTimePicker1.Value = DateTime.Now;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
        }
    }
}
