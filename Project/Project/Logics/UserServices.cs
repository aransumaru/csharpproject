using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Logics
{
    internal class UserServices:BaseServices
    {


        public User GetUserByAccount(string account)
        {
            return _context.Users.FirstOrDefault(u => u.Account == account);
        }

        public bool ValidateLogin(string account, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Account == account && u.Password == password);
            return user != null;
        }
    }
}
