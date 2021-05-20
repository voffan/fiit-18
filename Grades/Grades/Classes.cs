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


    }
}
