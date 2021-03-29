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
    public partial class RedEx : Form
    {
        public Context Db { get; set; }
        public RedEx(int id, string name, Int32 country, string city, DateTime date)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.country = country;
            this.city = city;
            this.date = date;
        }
        int id;
        string name;
        Int32 country;
        string city;
        DateTime date;

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = name;
            textBox2.Text = Convert.ToString(country);
            textBox3.Text = city;
            textBox4.Text = Convert.ToString(date.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ExhibitionLogic.SaveEditEx(Db, id, textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, DateTime.Parse(textBox4.Text));
                
                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
