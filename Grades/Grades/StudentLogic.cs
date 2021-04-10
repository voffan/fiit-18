using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class StudentLogic
    {
        public static void AddStudent(string Surname, string Name, string MiddleName,
            DateTime DateOfBirth, string Address, string Phone, int ClassId, Context db)
        {
            Student epl = new Student();
            epl.Surname = Surname;
            epl.Name = Name;
            epl.MiddleName = MiddleName;
            epl.DateOfBirth = DateOfBirth;
            epl.Address = Address;
            epl.Phone = Phone;
            epl.ClassId = ClassId;
            db.Students.Add(epl);
            db.SaveChanges();
        }

        public static void DeleteStudent(Context db, int id)
        {
            Student epl = db.Students.Where(e => e.Id == id).FirstOrDefault();
            db.Students.Remove(epl);
            db.SaveChanges();
        }
    }
}
