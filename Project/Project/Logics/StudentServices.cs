using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project.Models.StudentInfor;

namespace Project.Logics
{
    internal class StudentServices: BaseServices
    {
        public string messageBox = "";
        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
        public List<StudentInfo> GetStudentInfoByClassName(string className)
        {
            var studentInfo = _context.ClassStudentSubjects
                .Where(css => css.Class.ClassName == className)
                .Select(css => new StudentInfo
                {
                    StudentId = css.Student.StudentId,
                    StudentName = css.Student.StudentName,
                    SubjectName = css.Subject.SubjectName,
                    Lab1 = css.Student.ScoreSubjectStudents
                        .Where(sss => sss.SubjectId == css.SubjectId)
                        .Select(sss => sss.Score.Lab1)
                        .FirstOrDefault(),
                    Lab2 = css.Student.ScoreSubjectStudents
                        .Where(sss => sss.SubjectId == css.SubjectId)
                        .Select(sss => sss.Score.Lab2)
                        .FirstOrDefault(),
                    Assignment = css.Student.ScoreSubjectStudents
                        .Where(sss => sss.SubjectId == css.SubjectId)
                        .Select(sss => sss.Score.Assignment)
                        .FirstOrDefault(),
                    TheoryExam = css.Student.ScoreSubjectStudents
                        .Where(sss => sss.SubjectId == css.SubjectId)
                        .Select(sss => sss.Score.TheoryExam)
                        .FirstOrDefault(),
                    PracticalExam = css.Student.ScoreSubjectStudents
                        .Where(sss => sss.SubjectId == css.SubjectId)
                        .Select(sss => sss.Score.PracticalExam)
                        .FirstOrDefault()
                })
                .ToList();

            return studentInfo;
        }
        public List<int> GetStudentIds()
        {
            var studentIds = _context.Students.Select(s => s.StudentId).ToList();
            return studentIds;
        }
        public StudentInfo GetStudentInfoByStudentIdAndSubjectName(int studentId, string subjectName)
        {
            var studentInfo = _context.Students
                .Where(s => s.StudentId == studentId)
                .Select(s => new StudentInfo
                {
                    StudentName = s.StudentName,
                    Lab1 = s.ScoreSubjectStudents
                        .Where(sss => sss.Subject.SubjectName == subjectName)
                        .Select(sss => sss.Score.Lab1)
                        .FirstOrDefault(),
                    Lab2 = s.ScoreSubjectStudents
                        .Where(sss => sss.Subject.SubjectName == subjectName)
                        .Select(sss => sss.Score.Lab2)
                        .FirstOrDefault(),
                    Assignment = s.ScoreSubjectStudents
                        .Where(sss => sss.Subject.SubjectName == subjectName)
                        .Select(sss => sss.Score.Assignment)
                        .FirstOrDefault(),
                    TheoryExam = s.ScoreSubjectStudents
                        .Where(sss => sss.Subject.SubjectName == subjectName)
                        .Select(sss => sss.Score.TheoryExam)
                        .FirstOrDefault(),
                    PracticalExam = s.ScoreSubjectStudents
                        .Where(sss => sss.Subject.SubjectName == subjectName)
                        .Select(sss => sss.Score.PracticalExam)
                        .FirstOrDefault()
                })
                .FirstOrDefault();

            return studentInfo;
        }

        public List<int> GetStudentIdsByClass(string className)
        {
            var studentIds = _context.ClassStudentSubjects
                .Where(css => css.Class.ClassName == className)
                .Select(css => css.Student.StudentId)
                .ToList();

            return studentIds;
        }



    }
}
