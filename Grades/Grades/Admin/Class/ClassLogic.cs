using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ClassLogic
    {
        public static void AddClass(int Year, int SchoolId,int EmployeeId,Context db)
        {
            Class epl = new Class();
            epl.Year = Year;
            epl.SchoolId = SchoolId;
            epl.EmployeeId = EmployeeId;
            db.Classes.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteClass(Context db, int id)
        {
            Class epl = db.Classes.Where(e => e.Id == id).FirstOrDefault();
            db.Classes.Remove(epl);
            db.SaveChanges();
        }

        public static Class GetClass(Context db, int Id)
        {
            return db.Classes.Where(e => e.Id == Id).FirstOrDefault();
        }

        public static void EditClass(int Id, char Symbol, int Year,
             Context db)
        {
            Class cl = GetClass(db, Id);
            cl.Symbol = Symbol;
            cl.Year = Year;

            db.Entry(cl).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
