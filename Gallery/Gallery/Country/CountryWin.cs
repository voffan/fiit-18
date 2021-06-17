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
    public partial class CountryWin : Form
    {
        public Context Db { get; set; }
        public CountryWin()
        {
            InitializeComponent();
        }

        private void CountryWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Countries.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
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

                        CountryLogic.DelCountry(Db, id);

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
            dataGridView1.DataSource = Db.Countries.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryAdd ad = new CountryAdd();
            ad.Db = Db;
            ad.ShowDialog();
            dataGridView1.DataSource = Db.Countries.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
