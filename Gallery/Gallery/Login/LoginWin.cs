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
    public partial class LoginWin : Form
    {
        public Context db = new Context();
        public LoginWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            
            try
            {
                if (login == "admin")
                {
                    Form1 form = new Form1();
                    form.Db1 = this.db;
                    form.ShowDialog();
                }
                if (LoginLogic.LogAuth(db, login, pass))
                {
                    Form1 form = new Form1();
                    form.Db1 = this.db;
                    form.ShowDialog();
                }
                else MessageBox.Show("Пройдите авторизацию!", "Авторизация");
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка авторизации" + er.ToString(), "Авторизация");
            }
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

           
    }
}
