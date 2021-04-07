using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gallery
{
    public class LoginLogic
    {
        public static bool LogAuth(Context db, string log, string pass)
        {
            using (db)
            {
                var query = db.Auths
                                   .Where(a => a.Login == log)
                                   .FirstOrDefault<Auth>();
                if (query.Password == pass)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
