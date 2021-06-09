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
                User = AuthorizationLogic.logIn(Db, login, pass);
                if (User != null)
                {
                    switch (User.PositionId)
                    {
                        case 1:
                            {
                                Main form = new Main();
                                this.Hide();
                                form.ShowDialog();
                                Close();
                            }
                            break;
                        case 2:
                            {
                                DirectorMenu form = new DirectorMenu();
                                this.Hide();
                                form.ShowDialog();
                                Close();
                            }
                            break;
                        case 3:
                            {
                                TeacherMenu form = new TeacherMenu();
                                this.Hide();
                                form.ShowDialog();
                                Close();
                            }
                            break;
                        case 4:
                            {
                                StudentMenu form = new StudentMenu();
                                this.Hide();
                                form.ShowDialog();
                                Close();
                            };
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
