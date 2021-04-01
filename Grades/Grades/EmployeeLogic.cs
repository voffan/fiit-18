using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public class EmployeeLogic
    {

        public static void AddEmployee(string Surname, string Name, string MiddleName,
            DateTime DateOfBirth, string Address, string Phone, int PositionId, int SchoolId, Context db)
    	{
    		Employee epl = new Employee();
            epl.Surname = Surname;
            epl.Name = Name;
            epl.MiddleName = MiddleName;
            epl.DateOfBirth = DateOfBirth;
            epl.Address = Address;
            epl.Phone = Phone;
            epl.PositionId = PositionId;
            epl.SchoolId = SchoolId;
            db.Employees.Add(epl);
            db.SaveChanges();
    	}

        public static void DeleteEmployee(Context db, int id)
        {
            Employee epl = db.Employees.Where(e => e.Id == id).FirstOrDefault();
            db.Employees.Remove(epl);
            
            db.SaveChanges();
            
        }
    }
}