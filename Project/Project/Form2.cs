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
            cbStudent.DisplayMember = "className";
            cbStudent.ValueMember = "className";
            var studentID = studentServices.GetStudentIds();
            cbStudent.DataSource = studentID;
            LoadForDGV();
        }
        private void LoadForDGV()
        {
            int selectedStudentId = Convert.ToInt32(cbStudent.SelectedValue);
            List<Student> student = studentServices.GetStudents();
            dataGridView1.DataSource = student;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
