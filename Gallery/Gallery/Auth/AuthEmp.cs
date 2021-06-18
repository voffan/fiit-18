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

    public partial class AuthEmp : Form
    {
        public string label;
        public Context Db1 { get; set; }
        public AuthEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaintWin form4 = new PaintWin();
            this.Hide();
            form4.Db = Db1;
            form4.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JournalForm jform = new JournalForm();
            this.Hide();
            jform.Db = Db1;
            jform.ShowDialog();
            this.Show();
        }

        private void AuthEmp_Load(object sender, EventArgs e)
        {
            label3.Text = label;
        }
    }
}
