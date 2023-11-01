using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    internal class StudentInfor
    {
        public class StudentInfo
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string SubjectName { get; set; }
            public DateTime? DOB { get; set; }
            public string ClassName { get; set; }
            public string Sex { get; set; } 
            public int? Lab1 { get; set; }
            public int? Lab2 { get; set; }
            public int? Assignment { get; set; }
            public int? TheoryExam { get; set; }
            public int? PracticalExam { get; set; }
        }
    }
}
