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
    }
}
