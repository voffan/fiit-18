using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gallery
{
    public partial class AuthAdmin : Form
    {
        public Context Db1 { get; set; }
        public AuthAdmin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeWin form2 = new EmployeeWin();
            form2.Db = Db1;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WinEx form3 = new WinEx();
            this.Hide();
            form3.Db = Db1;
            form3.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PaintWin form4 = new PaintWin();
            this.Hide();
            form4.Db = Db1;
            form4.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JournalForm jform = new JournalForm();
            this.Hide();
            jform.Db = Db1;
            jform.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellWin sellform = new SellWin();
            this.Hide();
            sellform.Db = Db1;
            sellform.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminAuthWin adaform = new AdminAuthWin();
            this.Hide();
            adaform.Db = Db1;
            
            adaform.ShowDialog();
            this.Show();
        }

        private void AuthAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CustWin cust = new CustWin();
            this.Hide();
            cust.Db = Db1;
            cust.ShowDialog();
            this.Show();
        }
    }
}
