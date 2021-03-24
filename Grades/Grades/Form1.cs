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
    }
}
