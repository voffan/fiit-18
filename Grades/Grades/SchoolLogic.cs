using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class SchoolLogic
    {
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
