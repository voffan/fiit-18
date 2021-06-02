using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class AdminAuthRed : Form
    {
        public Context Db { get; set; }
        public AdminAuthRed(int id, string login, string pass, int emp_id)
        {
            InitializeComponent();
            this.login = login;
            this.id = id;
            this.pass = pass;
            this.emp_id = emp_id;
        }
        string login;
        string pass;
        int emp_id;
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAuthLogic.SaveEditAuth(Db,textBox1.Text, textBox2.Text, (int)comboBox1.SelectedValue, id);

                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void AdminAuthRed_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Employees.ToList();
            comboBox1.DisplayMember = "FName";
            comboBox1.ValueMember = "Id";
        }
    }
}
