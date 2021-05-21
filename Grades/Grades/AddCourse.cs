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
    public partial class AddCourse : Form
    {
        private Context Db = new Context();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CourseLogic.AddCourse(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), Db);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Subjects.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = Db.Classes.ToList();
            comboBox2.DisplayMember = "Year";
            comboBox2.ValueMember = "Id";
            comboBox3.DataSource = Db.Groups.ToList();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
            comboBox4.DataSource = Db.Schools.ToList();
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Id";
        }
    }
}
