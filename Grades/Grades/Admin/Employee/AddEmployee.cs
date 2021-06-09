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
    public partial class AddEmployee : Form
    {
        private Context Db = new Context();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeLogic.AddEmployee(TextBox2.Text, TextBox3.Text,TextBox4.Text,DateTime.Parse(TextBox5.Text),
                    TextBox6.Text,TextBox7.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBoxSchool.SelectedValue), Db);
                Close();
            }catch(Exception  er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Positions.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBoxSchool.DataSource = Db.Schools.ToList();
            comboBoxSchool.DisplayMember = "Name";
            comboBoxSchool.ValueMember = "Id";
        }
    }
}
