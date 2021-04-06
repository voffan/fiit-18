using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class EmployeeWin : Form
    {
        public Context Db { get; set; }
        public EmployeeWin()
        {
            InitializeComponent();
        }

        private void EmployeeWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpAdd empAdd = new EmpAdd();
            empAdd.Db = this.Db;
            empAdd.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
