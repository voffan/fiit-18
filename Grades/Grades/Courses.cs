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
    public partial class Courses : Form
    {
        public Context Db { get; set; }
        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Courses.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Предмет";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Класс";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Подгруппа";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Учитель";
            dataGridView1.Columns[9].Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form AddCourse = new AddCourse();
            AddCourse.ShowDialog();
            dataGridView1.DataSource = Db.Courses.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseLogic.DeleteCourse(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Courses.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
