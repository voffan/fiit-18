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
    }
}
