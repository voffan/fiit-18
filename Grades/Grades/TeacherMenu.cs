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
    public partial class TeacherMenu : Form
    {
        private Context db = new Context();
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void TeacherMenu_Load(object sender, EventArgs e)
        {
            var courses = db.Courses
                    .Where(c => c.Employee.UserId == Authorization.User.Id)
                    .OrderBy(c => c.Employee.UserId)
                    .Select(c => c.Subject.Name)
                    .ToList();
            comboBox1.DataSource = courses;
            //var classes = db.TeacherSubjects
            //           .Where(c => c.UserId == Authorization.User.Id)
            //           .OrderBy(c => c.ClassId)
            //           .Select(c => c.ClassId);
            //foreach (int ids in classes)
            //    Console.WriteLine(ids);
            //classes = classes.Distinct();
            //comboBox1.DataSource = classes.ToList();
            //comboBox1.DataSource = db.Classes
            //           .Where(c => c.Id == classes.Class);
            //dataGridView1.DataSource = db.TeacherMarksTables.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var classes = db.Courses
                    .Where(c => c.Employee.UserId == Authorization.User.Id)
                    .Where(c => c.Subject.Id == Convert.ToInt32(comboBox1.SelectedValue))
                    .OrderBy(c => c.Employee.UserId)
                    .Select(c => new { id = c.Id, name = c.Class.Year })
                    .ToList();
            comboBox2.DataSource = classes;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var table = 
        }
    }
}
