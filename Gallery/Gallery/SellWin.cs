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
    public partial class SellWin : Form
    {
        public Context Db { get; set; }
        public SellWin()
        {
            InitializeComponent();
        }

        private void SellWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Sells.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
