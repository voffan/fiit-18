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
    public partial class ArtistRed : Form
    {
        public Context Db { get; set; }
        public ArtistRed(int i, string n, string s, string m, string b, string d)
        {
            InitializeComponent();
            id = i;
            name = n;
            surname = s;
            midname = m;
            birth = b;
            death = d;
        }

        int id;
        string name;
        string surname;
        string midname;
        string birth;
        string death;


        private void ArtistRed_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = midname;
            textBox3.Text = surname;
            textBox4.Text = birth;
            textBox5.Text = death;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ArtistLogic.SaveEditArt(Db, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, id);

                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != '.')
            {
                e.Handled = true;
            }
        }
    }
}
