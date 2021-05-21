using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grades
{
    public partial class Main : Form
    {
        private Context db = new Context();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            this.Hide();
            employees.Db = db;
            employees.ShowDialog();
            this.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ChekPoints chekPoints = new ChekPoints();
            this.Hide();
            chekPoints.Db = db;
            chekPoints.ShowDialog();
            this.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AcademicYears academicYears = new AcademicYears();
            this.Hide();
            academicYears.Db = db;
            academicYears.ShowDialog();
            this.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            this.Hide();
            students.Db = db;
            students.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            this.Hide();
            subjects.Db = db;
            subjects.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            this.Hide();
            classes.Db = db;
            classes.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Schools schools = new Schools();
            this.Hide();
            schools.Db = db;
            schools.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            this.Hide();
            courses.Db = db;
            courses.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            this.Hide();
            tables.Db = db;
            tables.ShowDialog();
            this.Show();
        }
    }
}
