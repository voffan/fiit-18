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
    public partial class CustRed : Form
    {
        public Context Db { get; set; }
        public CustRed(int id, string surname, string name, string m_name, int pass_id, int pass_series, string phone)
        {
            InitializeComponent();
            this.id = id;
            this.surname = surname;
            this.name = name;
            mid_name = m_name;
            pas_id = pass_id;
            pas_ser = pass_series;
            this.phone = phone;
        }
        int id;
        string surname;
        string name;
        string mid_name;
        int pas_id;
        int pas_ser;
        string phone;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLogic.SaveEditCust(Db, id, textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text);

                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void CustRed_Load(object sender, EventArgs e)
        {
            textBox1.Text = surname;
            textBox2.Text = name;
            textBox3.Text = mid_name;
            textBox4.Text = Convert.ToString(pas_id);
            textBox5.Text = Convert.ToString(pas_ser);
            textBox6.Text = phone;
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
