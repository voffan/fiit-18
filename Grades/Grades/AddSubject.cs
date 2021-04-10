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
    public partial class AddSubject : Form
    {
        private Context Db = new Context();
        public AddSubject()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SubjectLogic.AddSubject(TextBox1.Text, Db);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
