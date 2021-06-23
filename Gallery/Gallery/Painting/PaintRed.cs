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
    public partial class PaintRed : Form
    {
        public Context Db { get; set; }
        public PaintRed(int id, int genre_id, int? ex_id, string name_paint, int art_id, PaintingStatus paint_status)
        {
            InitializeComponent();
            comboBox3.Items.Add(Gallery.PaintingStatus.Хранилище);
            comboBox3.Items.Add(Gallery.PaintingStatus.Выставка);
            comboBox3.Items.Add(Gallery.PaintingStatus.Рестоврация);
            this.id = id;
            this.genre_id = genre_id;
            this.ex_id = ex_id;
            this.name_paint = name_paint;
            this.art_id = art_id;
            this.paint_status = paint_status; 
        }

        int id;
        int genre_id;
        int? ex_id;
        string name_paint;
        int art_id;
        PaintingStatus paint_status;
        private void PaintRed_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Genres.ToList();
            comboBox1.DisplayMember = "NameGenre";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = genre_id;
            comboBox2.DataSource = Db.Artists.ToList();
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedValue = art_id;      
            comboBox4.DataSource = Db.Exhibitions.ToList();
            comboBox4.DisplayMember = "NameExhibition";
            comboBox4.ValueMember = "Id";
            comboBox4.SelectedValue = ex_id;
            textBox2.Text = name_paint;
            if((int)paint_status==3)
            {
                comboBox3.Items.Add(Gallery.PaintingStatus.Продажа);
                comboBox3.SelectedIndex = (int)paint_status;
                comboBox3.Enabled = false;
            }else
            {
               comboBox3.SelectedIndex = (int)paint_status;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PaintLogic.SaveEditPaint(Db, (int)comboBox1.SelectedValue, (int)comboBox4.SelectedValue, textBox2.Text, (int)comboBox2.SelectedValue, (PaintingStatus)comboBox3.SelectedIndex, id);
                JournalLogic.JournalRed(Db, (PaintingStatus)comboBox3.SelectedIndex, (int)comboBox4.SelectedValue, id);
                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
