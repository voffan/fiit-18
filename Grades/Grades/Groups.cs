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
    public partial class Groups : Form
    {
        public Context Db { get; set; }
        public Groups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddGroup = new AddGroup();
            AddGroup.ShowDialog();
            dataGridView1.DataSource = Db.Groups.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupLogic.DeleteGroup(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Groups.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Groups.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название группы";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Предмет";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Класс";
            dataGridView1.Columns[6].Visible = false;
        }
    }
}
