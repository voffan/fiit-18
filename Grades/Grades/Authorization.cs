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
    public partial class Authorization : Form
    {
        private Context Db = new Context();
        public Authorization()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string pass = passField.Text;
            try
            {
                if (AuthorizationLogic.logIn(Db, login, pass))
                {
                    Main form = new Main();
                    form.ShowDialog();
                }
                else MessageBox.Show("Неверный логин и/или пароль");
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка авторизации" + er.ToString());
            }
        }
    }
}
