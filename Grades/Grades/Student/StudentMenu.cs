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
    public partial class StudentMenu : Form
    {
        private Context db = new Context();
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void buttonMarks_Click(object sender, EventArgs e)
        {
            StudentMarks stMarks = new StudentMarks();
            this.Hide();
            stMarks.Db = db;
            stMarks.ShowDialog();
            this.Show();
        }
    }
}
