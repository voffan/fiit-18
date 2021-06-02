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
    public partial class AdminAuthAdd : Form
    {
        public Context Db { get; set; }
        public AdminAuthAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminAuthAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Employees.ToList();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAuthLogic.AddAuth(Db, textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue));
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }
    }
}
