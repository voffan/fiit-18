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
    public partial class EmpRed : Form

    {
        public Context Db { get; set; }
        public EmpRed(int id, string name, string middle_name, string surname, int pass_id, int pass_series, string phone, int position, int depid, int stat)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.surname = surname;
            m_name = middle_name;
            this.pass_id = pass_id;
            pass_ser = pass_series;
            ph = phone;
            pos = (Position)position;
            dep_id = depid;
            st = (Status)stat;
        }

        int id;
        string name;
        string surname;
        string m_name;
        int pass_id;
        int pass_ser;
        string ph;
        Position pos;
        Status st;
        int dep_id;
        private void button2_Click(object sender, EventArgs e)
        {
            fclear();
        }
        private void fclear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeLogic.SaveEditEx(Db, textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, comboBox1.SelectedIndex, Convert.ToInt32(textBox8.Text), comboBox2.SelectedIndex, id);

                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void EmpRed_Load(object sender, EventArgs e)
        {

            textBox1.Text = name;
            textBox3.Text = surname;
            textBox2.Text = m_name;
            textBox4.Text = Convert.ToString(pass_id);
            textBox5.Text = Convert.ToString(pass_ser);
            textBox6.Text = ph;
            textBox8.Text = Convert.ToString(dep_id);
            comboBox1.SelectedIndex = (int)pos;
            comboBox2.SelectedIndex = (int)st;
        }
    }
}
