using Microsoft.EntityFrameworkCore;
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
    public partial class ClassManagement : Form
    {
        Prn211Context dbContext = new Prn211Context();
        ClassServices classServices = new ClassServices();
        SubjectServices subjectServices = new SubjectServices();
        StudentServices studentServices = new StudentServices();
        public ClassManagement()
        {
            InitializeComponent();
            var className = classServices.GetClassNames();
            cbClass.DataSource = className;
        }

        private void LoadForDGV1()
        {
            string selectedClass = cbClass.SelectedItem as string;
            string selectedSubject = cbSubject.SelectedItem as string;

            if (selectedClass != null && selectedSubject != null)
            {
                var studentsInfo = studentServices.GetStudentsByClassNameAndSubjectName(selectedClass, selectedSubject);

                dataGridView1.DataSource = studentsInfo;
            }
        }
        private void LoadForDGV2(string selectedClass)
        {
            if (selectedClass != null)
            {
                var allStudents = studentServices.GetListStudent();

                var studentsInClass = studentServices.GetStudentsByClassName(selectedClass)
                                        .Select(s => s.StudentId)
                                        .ToList();

                var studentsNotInClass = allStudents.Where(s => !studentsInClass.Contains(s.StudentId)).ToList();

                dataGridView2.DataSource = studentsNotInClass;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = cbClass.SelectedItem as string;
            if (selectedClass != null)
            {
                var subjects = subjectServices.GetSubjectNameByClassName(selectedClass);

                cbSubject.DataSource = new List<string> { subjects };
            }
            LoadForDGV1();
            LoadForDGV2(selectedClass);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string selectedClass = cbClass.SelectedItem as string;
            string selectedStudentName = studentNameText.Text;
            Student selectedStudent = studentServices.GetStudentByStudentName(selectedStudentName);
            if (!string.IsNullOrEmpty(selectedClass) && !string.IsNullOrEmpty(selectedStudentName))
            {
                if (selectedStudent != null &&
                    !studentServices.GetStudentIdsByClass(selectedClass).Contains(selectedStudent.StudentId))
                {
                    ClassStudentSubject newClassStudentSubject = new ClassStudentSubject
                    {
                        ClassId = _context.Classes.FirstOrDefault(c => c.ClassName == selectedClass)?.ClassId ?? 0,
                        StudentId = selectedStudent.StudentId,
                        SubjectId = _context.Subjects.FirstOrDefault()?.SubjectId ?? 0
                    };
                    Score newScore = new Score
                    {
                        Lab1 = 0,
                        Lab2 = 0,
                        Assignment = 0,
                        TheoryExam = 0,
                        PracticalExam = 0
                    };

                    _context.Scores.Add(newScore);
                    _context.SaveChanges();
                    newClassStudentSubject.Score = newScore;
                    _context.ClassStudentSubjects.Add(newClassStudentSubject);
                    _context.SaveChanges();
                    MessageBox.Show("Student added to the class successfully!");
                }
                else
                {
                    MessageBox.Show("Student is already in the selected class!");
                }
                LoadForDGV1();
                LoadForDGV2(selectedClass);
            }
            else
            {
                MessageBox.Show("Please select a class and a valid student name!");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string studentName = selectedRow.Cells["StudentName"].Value.ToString();
                studentNameText.Text = studentName;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                string studentName = selectedRow.Cells["StudentName"].Value.ToString(); 
                studentNameText.Text = studentName;
            }
        }
    }
}
