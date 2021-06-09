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
            var classes = db.TeacherSubjects
                       .Where(c => c.UserId == Authorization.User.Id)
                       .OrderBy(c => c.ClassId);
            comboBox1.DataSource = classes;

            dataGridView1.DataSource = db.TeacherMarksTables.ToList();
            dataGridView1.DataSource = db.Employees.ToList();
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].HeaderText = "Фамилия";
            //dataGridView1.Columns[2].HeaderText = "Имя";
            //dataGridView1.Columns[3].HeaderText = "Отчество";
            //dataGridView1.Columns[4].HeaderText = "Дата рождения";
            //dataGridView1.Columns[5].HeaderText = "Адрес";
            //dataGridView1.Columns[6].HeaderText = "Телефон";
            //dataGridView1.Columns[7].Visible = false;
            //dataGridView1.Columns[8].HeaderText = "Должность";
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].HeaderText = "Школа";
            //dataGridView1.Columns[11].Visible = false;
            //dataGridView1.Columns[12].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
