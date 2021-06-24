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
    public partial class Subjects : Form
    {
        public Context Db { get; set; }
        public Subjects()
        {
            InitializeComponent();
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Subjects.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название предмета";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AddSubject = new AddSubject();
            AddSubject.ShowDialog();
            dataGridView1.DataSource = Db.Subjects.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubjectLogic.DeleteSubject(Db, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            dataGridView1.DataSource = Db.Subjects.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Запись изменена");
            SubjectLogic.EditSubject(Convert.ToInt32(dataGridView1.CurrentCell.OwningRow.Cells[0].Value),
                dataGridView1.CurrentCell.OwningRow.Cells[1].Value.ToString(),
                Db);
        }
    }
}
