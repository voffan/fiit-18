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
    public partial class SPRed : Form
    {
        public Context Db { get; set; }
        public SPRed(int id, int price, int paintId)
        {
            InitializeComponent();
            this.id = id;
            this.price = price;
            this.paintId = paintId;
           
        }
        int price;
        int paintId;
        int id;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SPLogic.SaveEditEx(Db, Convert.ToInt32(textBox1.Text), (int)comboBox1.SelectedValue, id);

                MessageBox.Show("Запись отредактирована");
                Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Редактирование записи не выполнено: \n" + er.ToString());
            }
            Close();
        }

        private void SPRed_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Db.Paintings.ToList();
            comboBox1.DisplayMember = "NamePainting";
            comboBox1.ValueMember = "Id";
            textBox1.Text = Convert.ToString(price);
            comboBox1.SelectedValue = paintId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
