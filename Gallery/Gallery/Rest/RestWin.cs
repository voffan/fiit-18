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
    public partial class RestWin : Form
    {
        public Context Db { get; set; }
        public RestWin()
        {
            InitializeComponent();
        }

        private void RestWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.
                Where(p => p.PaintingStatus == (PaintingStatus)2).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Жанр";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Выставка";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Картина";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Художник";
            dataGridView1.Columns[8].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    RestLogic.SaveEditPaint(Db, id);
                    JournalLogic.SaveJournaldel(Db, id);
                }
                MessageBox.Show("Картина перемещена в хранилище");
                dataGridView1.Refresh();
                dataGridView1.DataSource = Db.Paintings.
                    Where(p => p.PaintingStatus == (PaintingStatus)2).ToList();
            }
            catch(Exception er)
            {
                MessageBox.Show("Удаление записи не выполнено: \n" + er.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.
                    Where(p => p.PaintingStatus == (PaintingStatus)2).ToList();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            dataGridView1.Rows[i].Selected = true;
                        }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.
                   Where(p => p.PaintingStatus == (PaintingStatus)2).ToList();
        }
    }
}
