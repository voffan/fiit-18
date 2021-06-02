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
    public partial class AddTable : Form
    {
        private Context Db = new Context();
        public AddTable()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                TableLogic.AddTable(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue),
                    Convert.ToInt32(comboBox4.SelectedValue), Convert.ToInt32(comboBox5.SelectedValue), Db);
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

        private void AddTable_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Students.ToList();
            comboBox1.DisplayMember = "Surname";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = Db.AcademicYears.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox3.DataSource = Db.CheckPoints.ToList();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";
            comboBox4.DataSource = Db.Courses.ToList();
            comboBox4.DisplayMember = "Subject";
            comboBox4.ValueMember = "Id";
            comboBox5.DataSource = Db.Marks.ToList();
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "Id";
        }
    }
}
