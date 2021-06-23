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
    public partial class AuthSell : Form
    {
        public string label;
        public Context Db1 { get; set; }
        public AuthSell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellWin sellform = new SellWin();
            this.Hide();
            sellform.Db = Db1;
            sellform.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPWin jform = new SPWin();
            this.Hide();
            jform.Db = Db1;
            jform.ShowDialog();
            this.Show();
        }

        private void AuthSell_Load(object sender, EventArgs e)
        {
            label3.Text = label;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustWin cust = new CustWin();
            this.Hide();
            cust.Db = Db1;
            cust.ShowDialog();
            this.Show();
        }
    }
}
