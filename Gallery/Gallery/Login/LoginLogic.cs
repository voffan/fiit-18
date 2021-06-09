using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Gallery
{
    public class LoginLogic
    {
        public static int LogAuth(Context db, string log, string pass)
        {
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] tmpHash = MD5.Create().ComputeHash(tmpSource);
            var query = db.Auths
                                .Where(a => a.Login == log)
                                .FirstOrDefault<Auth>();
            if (query != null && query.Password == Convert.ToString(tmpHash))
            {
                var query1 = db.Employees
                    .Where(b => b.Id == query.EmployeeId)
                    .FirstOrDefault<Employee>();
                if (query1.Position == (Position)0)
                {
                    return 0;
                }

                if (query1.Position == (Position)1)
                {
                    return 1;
                }
                if (query1.Position == (Position)2)
                {
                    return 2;
                }
                if (query1.Position == (Position)3)
                {
                    return 3;
                }
                return 4;
            }
            else return 10;
        }

    }
}
