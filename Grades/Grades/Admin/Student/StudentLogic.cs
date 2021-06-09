using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static Student GetStudent(Context db, int Id)
        {
            return db.Students.Where(e => e.Id == Id).FirstOrDefault();
        }

        public static void EditStudent(int Id, string Surname, string Name, string MiddleName, DateTime DateOfBirth,
            string Address, string Phone, int ClassId, Context db)
        {
            Student st = GetStudent(db, Id);
            st.Surname = Surname;
            st.Name = Name;
            st.MiddleName = MiddleName;
            st.DateOfBirth = DateOfBirth;
            st.Address = Address;
            st.Phone = Phone;
            st.ClassId = ClassId;

            db.Entry(st).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
