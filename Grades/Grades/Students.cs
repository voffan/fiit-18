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
    public partial class Students : Form
    {
        public Context Db { get; set; }
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddStudent = new AddStudent();
            AddStudent.ShowDialog();
            dataGridView1.DataSource = Db.Students.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentLogic.DeleteStudent(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Students.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
