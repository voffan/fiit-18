using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Gallery
{
    public partial class EmpAdd : Form
    {
        public Context Db { get; set; }
        public EmpAdd()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetNames(typeof(Gallery.Position));
            comboBox2.DataSource = Enum.GetValues(typeof(Gallery.Status));
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        
        private void EmpAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeLogic.AddEmployee(Db,textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, comboBox1.SelectedIndex, Convert.ToInt32(textBox8.Text), comboBox2.SelectedIndex);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

        private void fclear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            fclear();
        }
        
    }
}
