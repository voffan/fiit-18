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
    public partial class PaintAdd : Form
    {
        public Context Db { get; set; }
        public PaintAdd()
        {
            InitializeComponent();
            comboBox3.DataSource = Enum.GetValues(typeof(Gallery.PaintingStatus));
           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PaintAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Genres.ToList();
            comboBox1.DisplayMember = "NameGenre";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = Db.Artists.ToList();
            comboBox2.DisplayMember = "FName";
            comboBox2.ValueMember = "Id";
    
            comboBox4.DataSource = Db.Exhibitions.ToList();
            comboBox4.DisplayMember = "NameExhibition";
            comboBox4.ValueMember = "Id";
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
