using System;
using System.Collections.Generic;
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
    }
}
