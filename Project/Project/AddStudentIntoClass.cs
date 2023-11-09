using Project.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddStudentIntoClass : Form
    {
        ClassServices classServices = new ClassServices();
        StudentServices studentServices = new StudentServices();
        public AddStudentIntoClass()
        {
            InitializeComponent();
        }


        private void AddStudentIntoClass_Load(object sender, EventArgs e)
        {

        }
    }
}
