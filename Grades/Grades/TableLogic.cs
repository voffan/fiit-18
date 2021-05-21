using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class TableLogic
    {
        public static void AddTable(int StudentId, int AcademicYearId,int CheckPointId, int CourseId, int MarkId, Context db)
        {
            Table epl = new Table();
            epl.StudentId = StudentId;
            epl.AcademicYearId = AcademicYearId;
            epl.CheckPointId = CheckPointId;
            epl.CourseId = CourseId;
            epl.MarkId = MarkId;
            db.Tables.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteTable(Context db, int id)
        {
            Table epl = db.Tables.Where(e => e.Id == id).FirstOrDefault();
            db.Tables.Remove(epl);
            db.SaveChanges();
        }
    }
}
