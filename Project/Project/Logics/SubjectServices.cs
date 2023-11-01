using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logics
{
    internal class SubjectServices: BaseServices
    {
        public List<Subject> GetSubjects()
        {
            return _context.Subjects.ToList();
        }
        public string GetSubjectNameByClassNameAndStudentId(string className, int studentId)
        {
            var subjectName = _context.ClassStudentSubjects
                .Where(css => css.Class.ClassName == className && css.Student.StudentId == studentId)
                .Select(css => css.Subject.SubjectName)
                .FirstOrDefault();

            return subjectName;
        }

        public List<string> GetSubjectNames()
        {
            var dbContext = new Prn211Context();
            var subjectNames = dbContext.Subjects
                .Select(s => s.SubjectName)
                .ToList();

            return subjectNames;
        }
    }
}
