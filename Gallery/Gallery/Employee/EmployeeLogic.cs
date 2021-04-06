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
    }
}
