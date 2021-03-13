using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExhibitionLogic.AddEx(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, DateTime.Parse(textBox4.Text));
            }
            catch(Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

    }
}
