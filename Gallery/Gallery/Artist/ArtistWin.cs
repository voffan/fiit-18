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
    public partial class ArtistWin : Form
    {
        public Context Db { get; set; }
        public ArtistWin()
        {
            InitializeComponent();
        }

        private void ArtistWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Artists.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArtistAdd ar = new ArtistAdd();
            ar.Db = Db;
            ar.ShowDialog();
            dataGridView1.DataSource = Db.Artists.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Artist ex = ArtistLogic.GetArtById(Db, id);

                ArtistRed ar = new ArtistRed(id, ex.Name, ex.Surname, ex.Middle_Name, ex.BirthYear, ex.DeathYear);
                ar.Db = this.Db;
                ar.ShowDialog();
            }
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
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

                        ArtistLogic.DelArt(Db, id);

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
            dataGridView1.DataSource = Db.Artists.ToList();
        }
    }
}
