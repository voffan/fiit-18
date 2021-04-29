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
        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.dBDataSet.Course);

        }
    }
}
