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
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
            dataGridView1.Columns[5].HeaderText = "Адрес";
            dataGridView1.Columns[6].HeaderText = "Телефон";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Должность";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Школа";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
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
                Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[9].Value),
                Db );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            this.Hide();
            positions.Db = Db;
            positions.ShowDialog();
            this.Show();
        }
    }
}
