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
    public partial class SPAdd : Form
    {
        public Context Db { get; set; }
        public SPAdd()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SPAdd_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Paintings.ToList();
            comboBox1.DisplayMember = "NamePainting";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SPLogic.AddSellPainting(Db, Convert.ToInt32(textBox1.Text), (int)comboBox1.SelectedValue);
                JournalLogic.SaveJournal(Db, (int)comboBox1.SelectedValue);
                PaintLogic.SaveEditPaintSell(Db, PaintingStatus.Продажа, (int)comboBox1.SelectedValue);
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Запись не выполнена: \n" + er.ToString());
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
