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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dBDataSet.Employee);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeLogic.AddEmployee(TextBox3.Text, TextBox4.Text);
            }catch(Exception )
            {
                //ShowMessage("....");
            }
        }
    }
}
