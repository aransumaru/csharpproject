using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logics
{
    internal class BaseServices
    {
        protected Prn211Context _context;

        public BaseServices()
        {
            _context = new Prn211Context();
        }
    }
}
