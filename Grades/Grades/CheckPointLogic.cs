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
    }
}
