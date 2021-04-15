using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class EmployeeLogic
    {
        public static void AddEmployee(Context db, string name, string middle_name, string surname, int pass_id, int pass_series, string phone, int position, int depid, int stat)
        {
          
            Employee emp = new Employee
            {
                Name = name,
                Middle_Name = middle_name,
                Surname = surname,
                Passport_id = pass_id,
                Passport_series = pass_series,
                Phone = phone,
                Position = (Position)position,
                DepId = depid,
                Status = (Status)stat
            };
            db.Employees.Add(emp);
            db.SaveChanges();
        }
        public static void DelEmp(Context db, int ident)
        {
            Employee emp = db.Employees.Find(ident);
            db.Employees.Remove(emp);
            db.SaveChanges();
        }

        public static Employee GetEmpById(Context db, int ident)
        {

            Employee ex = db.Employees.Find(ident);

            return ex;
        }
        public static void SaveEditEx(Context db, string name, string middle_name, string surname, int pass_id, int pass_series, string phone, int position, int depid, int stat, int id)
        {

            Employee ex = GetEmpById(db, id);

            ex.Name = name;
            ex.Surname = surname;
            ex.Middle_Name = middle_name;
            ex.Passport_id = pass_id;
            ex.Passport_series = pass_series;
            ex.Phone = phone;
            ex.Position = (Position)position;
            ex.DepId = depid;
            ex.Status = (Status)stat;
          
   
            db.Entry(ex).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
        }
    }
}
