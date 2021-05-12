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

    public partial class WinEx : Form
    {
        public Context Db { get; set; } 
        public WinEx()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DobEx form = new DobEx();
            form.Db = this.Db;
            form.ShowDialog();
            dataGridView2.DataSource = Db.Exhibitions.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Db.Exhibitions.ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Название выставки";
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].HeaderText = "Страна";
            dataGridView2.Columns[4].HeaderText = "Город";
            dataGridView2.Columns[5].HeaderText = "Дата проведения";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Exhibition ex = ExhibitionLogic.GetExById(Db, id);

                RedEx form = new RedEx(id, ex.NameExhibition, ex.CountryId, ex.City, ex.Date);
                form.Db = this.Db; 
                form.ShowDialog();
            }
            dataGridView2.Refresh();
            dataGridView2.DataSource = Db.Exhibitions.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView2.SelectedRows.Count > 0)
                    {
                        int index = dataGridView2.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        
                        ExhibitionLogic.DelEx(Db, id);

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
            dataGridView2.DataSource = Db.Exhibitions.ToList();
        }
    }
}
