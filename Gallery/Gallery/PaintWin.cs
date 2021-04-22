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
    public partial class PaintWin : Form
    {
        public Context Db { get; set; }
        public PaintWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaintAdd padd = new PaintAdd();
            padd.Db = this.Db;
            padd.ShowDialog();
            dataGridView1.DataSource = Db.Exhibitions.ToList();
        }

        private void PaintWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Exhibitions.ToList();
        }
    }
}
