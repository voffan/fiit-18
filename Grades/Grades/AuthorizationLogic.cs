using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class AuthorizationLogic
    {
        public static bool logIn(Context db, string login, string pass)
        {
            var query = db.Users
                                .Where(a => a.UserName == login)
                                .FirstOrDefault<User>();
            if (query != null && query.Password == pass)
            {
                return true;
            }
            else return false;
        }
    }
}
