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
            AddEmployee.Show();
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
