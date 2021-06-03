using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class SchoolLogic
    {
        public static School GetSchool(Context db, int Id)
        {
            return db.Schools.Where(e => e.Id == Id).FirstOrDefault();
        }
        public static void EditSchool(Context Db, int id, string Name, string Address, string Email, string Phone)
        {
            School sch = GetSchool(Db, id);
            sch.Name = Name;
            sch.Address = Address;
            sch.Email = Email;
            sch.Phone = Phone;
            Db.Entry(sch).State = EntityState.Modified;
            Db.SaveChanges();
        }
        
        public static void AddSchool(string Name,string Address, string Email, string Phone, Context db)
        {
            School epl = new School();
            epl.Name = Name;
            epl.Address = Address;
            epl.Email = Email;
            epl.Phone = Phone;
            db.Schools.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteSchool(Context db, int id)
        {
            School epl = db.Schools.Where(e => e.Id == id).FirstOrDefault();
            db.Schools.Remove(epl);
            db.SaveChanges();
        }

        
    }
}
