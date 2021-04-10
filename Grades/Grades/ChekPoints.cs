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
    public partial class ChekPoints : Form
    {
        public Context Db { get; set; }
        public ChekPoints()
        {
            InitializeComponent();
        }

        private void ChekPoints_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.CheckPoints.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form AddCheckPoint = new AddCheckPoint();
            AddCheckPoint.ShowDialog();
            dataGridView1.DataSource = Db.CheckPoints.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckPointLogic.DeleteCheckPoint(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.CheckPoints.ToList();
        }
    }
}
