using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logics
{
    internal class ClassServices: BaseServices
    {
        public List<Class> GetClasses()
        {
            return _context.Classes.ToList();
        }
        public List<string> GetClassNames()
        {
            var dbContext = new Prn211Context();
            var classNames = dbContext.Classes
                .Select(c => c.ClassName)
                .ToList();

            return classNames;
        }
    }
}
