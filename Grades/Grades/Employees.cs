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
    public partial class Employees : Form
    {
        public Context Db { get; set; }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddEmployee = new AddEmployee();
            AddEmployee.ShowDialog();
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeLogic.DeleteEmployee(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentCell.OwningRow.Cells[0].Value.ToString());
            MessageBox.Show("Запись изменена");
            EmployeeLogic.EditEmployee(
                Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[0].Value),
                dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentCell.OwningRow.Cells[2].Value.ToString(),
                dataGridView1.CurrentCell.OwningRow.Cells[3].Value.ToString(),
                Convert.ToDateTime(dataGridView1.CurrentCell.OwningRow.Cells[4].Value),
                dataGridView1.CurrentCell.OwningRow.Cells[5].Value.ToString(),
                dataGridView1.CurrentCell.OwningRow.Cells[6].Value.ToString(),
                Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[7].Value),
                Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[8].Value),
                Db );
        } 
    }
}
