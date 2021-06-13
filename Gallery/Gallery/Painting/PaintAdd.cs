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
            try
            {
                PaintLogic.AddPaint(Db, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox4.SelectedValue), textBox2.Text, Convert.ToInt32(comboBox2.SelectedValue), comboBox2.SelectedIndex);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_KeyUp(object sender, KeyEventArgs e)
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

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
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
    }
}
