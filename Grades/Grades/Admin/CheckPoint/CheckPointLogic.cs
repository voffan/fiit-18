using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class CheckPointLogic
    {
        public static void AddCheckPoint(string Name, Context db)
        {
            CheckPoint epl = new CheckPoint();
            epl.Name = Name;
            db.CheckPoints.Add(epl);
            db.SaveChanges();
        }
        public static void DeleteCheckPoint(Context db, int id)
        {
            CheckPoint epl = db.CheckPoints.Where(e => e.Id == id).FirstOrDefault();
            db.CheckPoints.Remove(epl);
            db.SaveChanges();
        }
    }
}
