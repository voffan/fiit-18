using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class EmployeeLogic
    {
    	public static void AddEmployee(...)
    	{
    		Employee epl = new Employee();
            epl.Surname =textBox2.Text;
            epl.Name = textBox3.Text;
            ....
            Context db = new Context();
            db.Employees.Add(epl);
            db.SaveChanges();
    	}
	}
}