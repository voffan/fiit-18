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
    public partial class SellRed : Form
    {
        public Context Db { get; set; }
        public SellRed(int id, long price, DateTime date, StatusSell status, int customer_id)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Gallery.StatusSell));
            this.id = id;
            this.price = price;
            this.date = date;
            status1 = status;
            this.customer_id = customer_id;
        }
        int id;
        long price;
        DateTime date;
        StatusSell status1;
        int customer_id;

        private void SellRed_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = Db.Customers.ToList();
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Id";
            textBox1.Text = Convert.ToString(price);
            comboBox2.SelectedValue = (int)customer_id;
            dateTimePicker1.Value = date;
            comboBox1.SelectedIndex = (int)status1; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SellLogic.SaveEditEx(Db, Convert.ToInt32(textBox1.Text), dateTimePicker1.Value, comboBox1.SelectedIndex, Convert.ToInt32(comboBox2.SelectedValue), id);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
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
    }
}
