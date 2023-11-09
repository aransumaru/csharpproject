using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
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
        public List<Student> GetListStudent(Prn211Context context)
        {
            return context.Students.ToList();
        }
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
                    Sex = css.Student.Sex,
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
        public Student GetStudentByStudentId(int studentId)
        {
            var student = _context.Students
                .Where(s => s.StudentId == studentId)
                .FirstOrDefault();

            return student;
        }
        public StudentInfo GetStudentInfoByStudentId(int studentId)
        {
            var studentInfo = _context.Students
                .Where(s => s.StudentId == studentId)
                .Select(s => new StudentInfo
                {
                    StudentId = s.StudentId,
                    StudentName = s.StudentName,
                    Sex = s.Sex,
                    DOB = s.Dob,
                    ClassName = string.Join(", ", s.ClassStudentSubjects.Select(css => css.Class.ClassName).Distinct()),
                    SubjectName = string.Join(", ", s.ClassStudentSubjects.Select(css => css.Subject.SubjectName).Distinct())
                })
                .FirstOrDefault();

            return studentInfo;
        }
        public List<StudentInfo> GetListStudent()
        {
            var studentsInfo = _context.Students.Select(s => new StudentInfo
            {
                StudentId = s.StudentId,
                StudentName = s.StudentName,
                Sex = s.Sex,
                DOB = s.Dob,
                ClassName = string.Join(", ", s.ClassStudentSubjects.Select(css => css.Class.ClassName).Distinct()),
                SubjectName = string.Join(", ", s.ClassStudentSubjects.Select(css => css.Subject.SubjectName).Distinct())
            }).ToList();

            return studentsInfo;
        }
        public Student GetStudentByStudentName(string studentName)
        {
            var student = _context.Students
                .Where(s => s.StudentName == studentName)
                .FirstOrDefault();

            return student;
        }
        public void AddStudent(Student student)
        {
            int nextStudentId = 1;

            if (_context.Students.Any())
            {
                nextStudentId = _context.Students.Max(s => s.StudentId) + 1;
            }

            student.StudentId = nextStudentId;
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int studentId)
        {
            Student student = _context.Students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

        public List<StudentInfo> GetStudentsByClassNameAndSubjectName(string className, string subjectName)
        {
            var studentsInfo = _context.ClassStudentSubjects
                .Where(css => css.Class.ClassName == className && css.Subject.SubjectName == subjectName)
                .Select(css => new StudentInfo
                {
                    StudentId = css.Student.StudentId,
                    StudentName = css.Student.StudentName,
                    Sex = css.Student.Sex,
                    DOB = css.Student.Dob,
                    ClassName = css.Class.ClassName,
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

            return studentsInfo;
        }
        public List<StudentInfo> GetStudentsByClassName(string className)
        {
            var studentsByClass = _context.ClassStudentSubjects
                .Where(css => css.Class.ClassName == className)
                .Select(css => new StudentInfo
                {
                    StudentId = css.Student.StudentId,
                    StudentName = css.Student.StudentName,
                })
                .ToList();

            return studentsByClass;
        }


    }
}
