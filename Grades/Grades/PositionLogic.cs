using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class PositionLogic
    {
        public static void AddPosition(string Name, Context db)
        {
            Position epl = new Position();
            epl.Name = Name;
            db.Positions.Add(epl);
            db.SaveChanges();
        }
        public static void DeletePosition(Context db, int id)
        {
            Position epl = db.Positions.Where(e => e.Id == id).FirstOrDefault();
            db.Positions.Remove(epl);
            db.SaveChanges();
        }
    }
}
