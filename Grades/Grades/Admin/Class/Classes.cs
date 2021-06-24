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
    public partial class Classes : Form
    {
        public Context Db { get; set; }
        public Classes()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Classes.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Подгруппа класса";
            dataGridView1.Columns[2].HeaderText = "Класс";
            dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].HeaderText = "Школа";
            dataGridView1.Columns[4].Visible = false;

            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            cb.DataSource = Db.Schools.ToList();
            cb.HeaderText = "Школа";
            cb.DataPropertyName = "SchoolId";
            cb.DropDownWidth = 160;
            cb.MaxDropDownItems = 5;
            cb.Width = 90;
            cb.Visible = true;
            cb.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.RemoveAt(4);
            dataGridView1.Columns.Insert(4, cb);

            dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[6].HeaderText = "Классный руководитель";
            //dataGridView1.Columns[6].Width = 250;
            dataGridView1.Columns[6].Visible = false;

            cb = new DataGridViewComboBoxColumn();
            cb.DisplayMember = "Surname";
            cb.ValueMember = "Id";
            cb.DataSource = Db.Employees.ToList();
            cb.HeaderText = "Классный руководитель";
            cb.DataPropertyName = "EmployeeId";
            cb.DropDownWidth = 160;
            cb.MaxDropDownItems = 5;
            cb.Width = 90;
            cb.Visible = true;
            cb.FlatStyle = FlatStyle.Flat;
            dataGridView1.Columns.RemoveAt(6);
            dataGridView1.Columns.Insert(6, cb);

            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddClass = new AddClass();
            AddClass.ShowDialog();
            dataGridView1.DataSource = Db.Classes.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClassLogic.DeleteClass(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Classes.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            this.Hide();
            groups.Db = Db;
            groups.ShowDialog();
            this.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Запись изменена");
            ClassLogic.EditClass(Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[0].Value),
                Convert.ToChar(dataGridView1.CurrentCell.OwningRow.Cells[1].Value),
                Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[2].Value),
                Db);
        }
    }
}
