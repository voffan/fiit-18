using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class AcademicYearLogic
    {
        public static void AddAcademicYear(DateTime Start, DateTime End, Context db)
        {
            AcademicYear epl = new AcademicYear();
            epl.Start = Start;
            epl.End = End;
            db.AcademicYears.Add(epl);
            db.SaveChanges();
        }
        public static void DeleteAcademicYear(Context db, int id)
        {
            AcademicYear epl = db.AcademicYears.Where(e => e.Id == id).FirstOrDefault();
            db.AcademicYears.Remove(epl);
            db.SaveChanges();
        }
        public static AcademicYear GetAcademicYear(Context db, int Id)
        {
            return db.AcademicYears.Where(e => e.Id == Id).FirstOrDefault();
        }

        public static void EditAcademicYear(int Id, string Start, string End, Context db)
        {
            AcademicYear ac = GetAcademicYear(db, Id);
            ac.Start = Convert.ToDateTime(Start);
            ac.End = Convert.ToDateTime(End);

            db.Entry(ac).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
