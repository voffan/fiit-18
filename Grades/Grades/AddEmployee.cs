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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Employees main = this.Owner as Employees;
            if (main != null)
            {
                DataRow nRow = main.dBDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                nRow[5] = textBox6.Text;
                nRow[6] = textBox7.Text;
                nRow[7] = textBox8.Text;
                nRow[8] = textBox1.Text;
                main.dBDataSet.Tables[0].Rows.Add(nRow);
                main.employeeTableAdapter.Update(this.dBDataSet.Employee);
                main.dBDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
