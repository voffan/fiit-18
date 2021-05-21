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
    public partial class AddClass : Form
    {
        private Context Db = new Context();
        public AddClass()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassLogic.AddClass(Convert.ToInt32(TextBox2.Text), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Db);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

    private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = Db.Schools.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = Db.Employees.ToList();
            comboBox2.DisplayMember = "Surname";
            comboBox2.ValueMember = "Id";
        }
    }
}
