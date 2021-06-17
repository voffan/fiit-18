using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class DepLogic
    {
        public static void AddDep(Context db, string name)
        {
            Departament p = new Departament
            {
                name = name
            };

            db.Departaments.Add(p);
            db.SaveChanges();
        }
        public static void DelDep(Context db, int ident)
        {
            Departament p = db.Departaments.Find(ident);
            db.Departaments.Remove(p);
            db.SaveChanges();
        }
        public static Departament GetDepById(Context db, int ident)
        {
            Departament p = db.Departaments.Find(ident);
            return p;
        }
    }
}
