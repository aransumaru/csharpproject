using Project.Logics;
using Project.Models;
using System.Windows.Forms;
using static Project.Models.StudentInfor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form1 : Form
    {
        StudentServices studentServices = new StudentServices();
        ClassServices classServices = new ClassServices();
        ScoreServices scoreServices = new ScoreServices();

        public Form1()
        {
            InitializeComponent();
            cbClass.DisplayMember = "className";
            cbClass.ValueMember = "className";
            var classNames = classServices.GetClassNames();
            cbClass.DataSource = classNames;
            LoadForDGV();
        }
        private void LoadForDGV()
        {
            string selectedClassName = cbClass.SelectedValue.ToString();
            List<StudentInfo> studentInfo = studentServices.GetStudentInfoByClassName(selectedClassName);
            dataGridView1.DataSource = studentInfo;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStudentid.DataSource = null;
            string selectedClassName = cbClass.SelectedItem as string;
            var studentIds = studentServices.GetStudentIdsByClass(selectedClassName);
            cbStudentid.DataSource = studentIds;
            LoadForDGV();
        }

        private void lab1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbStudentid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentid.SelectedItem != null)
            {
                int selectedStudentId = (int)cbStudentid.SelectedItem;
                var studentInfo = studentServices.GetStudentInfoByStudentId(selectedStudentId);
                studentName.Text = studentInfo.StudentName;
                subjectText.Text = studentInfo.SubjectName;
                lab1.Text = studentInfo.Lab1.ToString();
                lab2.Text = studentInfo.Lab2.ToString();
                assignment.Text = studentInfo.Assignment.ToString();
                fe.Text = studentInfo.TheoryExam.ToString();
                pe.Text = studentInfo.PracticalExam.ToString();

            }

        }

        private void studentName_TextChanged(object sender, EventArgs e)
        {
            studentName.Enabled = false;


        }

        private void lab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignment_TextChanged(object sender, EventArgs e)
        {

        }

        private void fe_TextChanged(object sender, EventArgs e)
        {

        }

        private void pe_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (cbStudentid.SelectedItem != null)
            {
                int selectedStudentId = (int)cbStudentid.SelectedItem;
                int lab1Score = int.Parse(lab1.Text);
                int lab2Score = int.Parse(lab2.Text);
                int assignmentScore = int.Parse(assignment.Text);
                int theoryExamScore = int.Parse(fe.Text);
                int practicalExamScore = int.Parse(pe.Text);
                scoreServices.messageBox = "";
                bool updated = scoreServices.UpdateStudentInfo(selectedStudentId, lab1Score, lab2Score, assignmentScore, theoryExamScore, practicalExamScore);

                string selectedClassName = cbClass.SelectedValue.ToString();
                List<StudentInfo> studentInfo = studentServices.GetStudentInfoByClassName(selectedClassName);
                dataGridView1.DataSource = studentInfo;
                dataGridView1.Refresh();
            }


        }

        private void subjectText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}