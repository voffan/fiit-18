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
    public partial class AdminAuthWin : Form
    {
        public Context Db { get; set; }
        public AdminAuthWin()
        {
            InitializeComponent();
        }

        private void AdminAuthWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Auths.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "ФИО сотрудника";
        }

            private void button1_Click(object sender, EventArgs e)
        {
            AdminAuthAdd AuthAdd = new AdminAuthAdd();
            AuthAdd.Db = this.Db;
            AuthAdd.ShowDialog();
            dataGridView1.DataSource = Db.Auths.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
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

                        AdminAuthLogic.DelAuth(Db, id);

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
            dataGridView1.DataSource = Db.Auths.ToList();
        }
        
        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AdminAuthLogic.GetOrderedAuthFullname(Db);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Auths.ToList();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Auths.ToList();
        }
    }
}
