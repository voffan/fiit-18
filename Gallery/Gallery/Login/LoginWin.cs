﻿using System;
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
               
                if (LoginLogic.LogAuth(db, login, pass)==0)
                {
                    AuthAdmin form = new AuthAdmin();
                    form.Db1 = this.db;
                    form.Show();
                    this.Hide();
                    
                }

                if (LoginLogic.LogAuth(db, login, pass) == 1)
                {
                    AuthRest form = new AuthRest();
                    form.Db1 = this.db;
                    form.ShowDialog();
                }
                if (LoginLogic.LogAuth(db, login, pass) == 2)
                {
                    AuthSell form = new AuthSell();
                    form.Db1 = this.db;
                    form.ShowDialog();
                }

                if (LoginLogic.LogAuth(db, login, pass) == 3)
                {
                    AuthEmp auth_form = new AuthEmp();
                    auth_form.Db1 = this.db;
                    auth_form.ShowDialog();
                }
                if (LoginLogic.LogAuth(db, login, pass) == 10)
                {
                    MessageBox.Show("Ошибка автторизации!");
                }


            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка авторизации" + er.ToString(), "Авторизация");
            }
        }

        private void LoginWin_Load(object sender, EventArgs e)
        {
            CenterLabel(label1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CenterLabel(Label label)
        {
            label.Width = this.Width - 10;
            label.Left = this.Width / 2 - label.Width / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
