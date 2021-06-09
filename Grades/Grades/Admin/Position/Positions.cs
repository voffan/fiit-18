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
    public partial class Positions : Form
    {
        public Context Db { get; set; }
        public Positions()
        {
            InitializeComponent();
        }

        private void Positions_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Positions.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название должности";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form AddPositions = new AddPosition();
            AddPositions.ShowDialog();
            dataGridView1.DataSource = Db.Positions.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PositionLogic.DeletePosition(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.CheckPoints.ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
