using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class AuthorizationLogic
    {
        public static User logIn(Context db, string login, string pass)
        {
            var query = db.Users
                                .Where(a => a.UserName == login)
                                .FirstOrDefault<User>();
            if (query != null && query.Password == pass)
            {
                return query;
                //int role;
                //switch (query.Role)
                //{
                //    case "Admin":
                //        role = 1;
                //        break;
                //    case "Director":
                //        role = 2;
                //        break;
                //    case "Teacher":
                //        role = 3;
                //        break;
                //    case "Student":
                //        role = 4;
                //        break;
                //    default:
                //        role = -1;
                //        break;
                //}
                //return role;
                
            }
            else return null;
        }
    }
}
