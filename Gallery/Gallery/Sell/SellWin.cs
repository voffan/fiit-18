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
    public partial class SellWin : Form
    {
        public Context Db { get; set; }
        public SellWin()
        {
            InitializeComponent();
        }

        private void SellWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Sells.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер продажи";
            dataGridView1.Columns[1].HeaderText = "Цена";
            dataGridView1.Columns[2].HeaderText = "Дата продажи";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellAdd sellAdd = new SellAdd();
            sellAdd.Db = this.Db;
            sellAdd.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Sell ex = SellLogic.GetSellById(Db, id);

                SellRed form = new SellRed(id, ex.Price, ex.Date, ex.Status, ex.CustomerId);
                form.Db = this.Db;
                form.ShowDialog();
            }
            dataGridView1.Refresh();
            dataGridView1.DataSource = Db.Sells.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
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

                        SellLogic.DelSell(Db, id);

                        MessageBox.Show("Запись удалена");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Удаление записи не выполнено: \n" + er.ToString());
                }
            }
            else
            {

            }
            dataGridView1.DataSource = Db.Sells.ToList();
        }

        private void ценеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SellLogic.GetOrderedSellPrice(Db);
        }

        private void датаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SellLogic.GetOrderedSellDate(Db);
        }

        private void покупателямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SellLogic.GetOrderedSellCust(Db);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Sells.ToList();
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
            dataGridView1.DataSource = Db.Sells.ToList();
        }
    }
}
