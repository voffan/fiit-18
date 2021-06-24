using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static Subject GetSubject(Context db, int Id)
        {
            return db.Subjects.Where(e => e.Id == Id).FirstOrDefault();
        }

        public static void EditSubject(int Id, string Name, Context db)
        {
            Subject sub = GetSubject(db, Id);
            sub.Name = Name;

            db.Entry(sub).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
