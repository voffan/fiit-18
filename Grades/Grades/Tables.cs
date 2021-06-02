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
    public partial class Tables : Form
    {
        public Context Db { get; set; }
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Tables.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Ученик";
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Академический год";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Контрольная точка";
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Курс";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].HeaderText = "Оценка";
            dataGridView1.Columns[10].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddTable = new AddTable();
            AddTable.ShowDialog();
            dataGridView1.DataSource = Db.Tables.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableLogic.DeleteTable(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
