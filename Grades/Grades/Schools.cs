﻿using System;
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
    public partial class Schools : Form
    {
        public Context Db { get; set; }
        public Schools()
        {
            InitializeComponent();
        }

        private void Schools_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Schools.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form AddSchool = new AddSchool();
            AddSchool.ShowDialog();
            dataGridView1.DataSource = Db.Schools.ToList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SchoolLogic.DeleteSchool(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Schools.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
