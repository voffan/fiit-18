using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class SubjectLogic
    {

        public static void AddSubject(string Name, Context db)
        {
            Subject epl = new Subject();
            epl.Name = Name;
            db.Subjects.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteSubject(Context db, int id)
        {
            Subject epl = db.Subjects.Where(e => e.Id == id).FirstOrDefault();
            db.Subjects.Remove(epl);
            db.SaveChanges();
        }
    }
}
