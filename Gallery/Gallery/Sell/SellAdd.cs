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
    
    public partial class SellAdd : Form
    {
        public Context Db { get; set; }
        public SellAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SellLogic.AddSell(Db,Convert.ToInt64(textBox1.Text), dateTimePicker1.Value,(StatusSell)comboBox1.SelectedIndex,Convert.ToInt32(comboBox2.Text));
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SellAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Gallery.StatusSell));
            comboBox2.DataSource = Db.Customers.ToList();
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Id";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
