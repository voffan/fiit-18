using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class AdminAuthLogic
    {
        public static void AddAuth(Context db, string login, string pass, int emp_id)
        {

            Auth p = new Auth
            {
               Login = login,
               Password = pass,
               EmployeeId = emp_id
            };

            db.Auths.Add(p);
            db.SaveChanges();
        }
        public static void DelAuth(Context db, int ident)
        {
            Auth p = db.Auths.Find(ident);
            db.Auths.Remove(p);
            db.SaveChanges();
        }
        public static Auth GetAuthById(Context db, int ident)
        {
            Auth p = db.Auths.Find(ident);
            return p;
        }
        public static void SaveEditAuth(Context db, string login, string pass, int emp_id, int id)
        {

            Auth p = GetAuthById(db, id);

            p.Login = login;
            p.Password = pass;
            p.EmployeeId = emp_id;
            db.Entry(p).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
    }
}
