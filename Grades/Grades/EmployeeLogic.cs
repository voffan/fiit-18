using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public class EmployeeLogic
    {
        public static void AddEmployee(string TextBox2, string TextBox3, string TextBox4,
            DateTime TextBox5, string TextBox6, int TextBox7, int? TextBox8, int? TextBox1)
    	{
    		Employee epl = new Employee();
            epl.Surname = TextBox2;
            epl.Name = TextBox3;
            epl.MiddleName = TextBox4;
            epl.DateOfBirth = TextBox5;
            epl.Address = TextBox6;
            epl.Phone = TextBox7;
            epl.PositionId = TextBox8;
            epl.SchoolId = TextBox1;
            Context db = new Context();
            db.Employees.Add(epl);
            db.SaveChanges();
    	}

        public static void Save—hanges()
        {
            Context db = new Context();
            db.SaveChanges();
        }

        internal static void AddEmployee(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}