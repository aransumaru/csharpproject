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
    }
}
