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
    public partial class PaintWin : Form
    {
        public Context Db { get; set; }
        public PaintWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaintAdd padd = new PaintAdd();
            padd.Db = this.Db;
            padd.ShowDialog();
            dataGridView1.DataSource = Db.Paintings.ToList();
        }

        private void PaintWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Жанр";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Выставка";
            dataGridView1.Columns[5].HeaderText = "Картина";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].HeaderText = "Художник";
            dataGridView1.Columns[8].HeaderText = "Статус";
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
                Painting ex = PaintLogic.GetPaintById(Db, id);

                PaintRed form = new PaintRed(id, ex.GenreId, ex.ExhibitionId, ex.NamePainting, ex.ArtistId, ex.PaintingStatus);
                form.Db = this.Db;
                form.ShowDialog();
            }
            dataGridView1.Refresh();
            dataGridView1.DataSource = Db.Paintings.ToList();
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

                        PaintLogic.DelPaint(Db, id);

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
            dataGridView1.DataSource = Db.Paintings.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.ToList();
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Paintings.ToList();
        }

        private void навзванииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaintLogic.GetOrderedPaintingName(Db);
        }

        private void жанруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaintLogic.GetOrderedPaintingGenre(Db);
        }

        private void авторамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaintLogic.GetOrderedPaintingArstist(Db);
        }

        private void выставкамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PaintLogic.GetOrderedPaintingExhib(Db);
        }
    }
}
