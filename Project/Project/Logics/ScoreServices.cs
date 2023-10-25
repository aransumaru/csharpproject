using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Logics
{
    internal class ScoreServices: BaseServices
    {
        public string messageBox = "";
        public List<Score> GetScores()
        {
            return _context.Scores.ToList();
        }
        public bool UpdateStudentInfo(int studentId, string subjectName, int lab1, int lab2, int assignment, int theoryExam, int practicalExam)
        {
            if (lab1 < 0 || lab1 > 10 || lab2 < 0 || lab2 > 10 || assignment < 0 || assignment > 10 || theoryExam < 0 || theoryExam > 10 || practicalExam < 0 || practicalExam > 10)
            {
                messageBox = "The Score (Lab1, Lab2, Assignment, Theory Exam, Practical Exam) must be >= 0 and <= 10.";
                MessageBox.Show(messageBox);
                return false;
            }

            var scoreSubjectStudent = _context.Students
                .Where(s => s.StudentId == studentId)
                .SelectMany(s => s.ScoreSubjectStudents)
                .Include(sss => sss.Score)
                .Select(sss => new
                {
                    SubjectName = sss.Subject.SubjectName,
                    Score = sss.Score
                })
                .FirstOrDefault(sss => sss.SubjectName == subjectName);

            if (scoreSubjectStudent != null)
            {
                var score = scoreSubjectStudent.Score;
                score.Lab1 = lab1;
                score.Lab2 = lab2;
                score.Assignment = assignment;
                score.TheoryExam = theoryExam;
                score.PracticalExam = practicalExam;
                _context.SaveChanges();
                messageBox = "Student information updated successfully.";
                MessageBox.Show(messageBox);
                return true;
            }
            else
            {
                messageBox = "Subject not found for the specified student.";
                MessageBox.Show(messageBox);
                return false;
            }
        }

    }
}
