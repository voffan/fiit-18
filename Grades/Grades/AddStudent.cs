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
    public partial class AddStudent : Form
    {
        private Context Db = new Context();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentLogic.AddStudent(TextBox2.Text, TextBox3.Text, TextBox4.Text, DateTime.Parse(TextBox5.Text),
                    TextBox6.Text, TextBox7.Text, Convert.ToInt32(comboBox1.SelectedValue), Db);
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

        private void AddStudent_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Classes.ToList();
            comboBox1.DisplayMember = "Year";
            comboBox1.ValueMember = "Id";
        }
    }
}
