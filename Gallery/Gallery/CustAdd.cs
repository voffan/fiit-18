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
    public partial class CustAdd : Form
    {
        public Context Db { get; set; }
        public CustAdd()
        {
            InitializeComponent();
        }

        private void CustAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Sells.ToList();
            comboBox1.DisplayMember = "Status";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic.AddCust(Db,textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
