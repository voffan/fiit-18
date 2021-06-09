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
    public partial class AcademicYears : Form
    {
        public Context Db { get; set; }
        public AcademicYears()
        {
            InitializeComponent();
        }

        private void AcademicYears_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.AcademicYears.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Начало";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Конец";
            dataGridView1.Columns[2].Width = 150;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form AddAcademicYear = new AddAcademicYear();
            AddAcademicYear.ShowDialog();
            dataGridView1.DataSource = Db.AcademicYears.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AcademicYearLogic.DeleteAcademicYear(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.AcademicYears.ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
