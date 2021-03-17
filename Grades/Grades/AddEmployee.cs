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
        private Context DB = new Context();
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
                EmployeeLogic.AddEmployee(TextBox2.Text, TextBox3.Text,TextBox4.Text,DateTime.Parse(TextBox5.Text),
                    TextBox6.Text,Convert.ToInt32(TextBox7.Text), Convert.ToInt32(TextBox8.Text), Convert.ToInt32(TextBox1.Text));
            }catch(Exception  er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
