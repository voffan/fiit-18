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
        public static User User { get; set; }
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
                if (AuthorizationLogic.logIn(Db, login, pass) != 0)
                {
                    int role;
                    role = AuthorizationLogic.logIn(Db, login, pass);
                    switch (role)
                    {
                        case 1:
                            {
                                Main form = new Main();
                                form.ShowDialog();
                            }
                            break;
                        case 2:
                            MessageBox.Show("Авторизация в качестве директора выполнена");
                            break;
                        case 3:
                            MessageBox.Show("Авторизация в качестве учителя выполнена");
                            break;
                        case 4:
                            MessageBox.Show("Авторизация в качестве ученика выполнена");
                            break;
                        default:
                            MessageBox.Show("Error!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            break;
                    }
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
