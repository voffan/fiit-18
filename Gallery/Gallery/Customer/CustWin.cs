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
    public partial class CustWin : Form
    {
        public Context Db { get; set; }
        public CustWin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustAdd custAdd = new CustAdd();
            custAdd.Db = this.Db;
            custAdd.ShowDialog();
            dataGridView1.DataSource = Db.Customers.ToList();
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
                        bool converted = Int32.TryParse(dataGridView1[1, index].Value.ToString(), out id);
                        if (converted == false)
                            return;

                        CustomerLogic.DelCust(Db, id);

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
            dataGridView1.DataSource = Db.Customers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[1, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                Customer cr = CustomerLogic.GetCustById(Db, id);

                CustRed form = new CustRed(id, cr.Surname, cr.Name, cr.Middle_Name, cr.Passport_id, cr.Passport_series, cr.Phone);
                form.Db = this.Db;
                form.ShowDialog();
            }
            dataGridView1.Refresh();
            dataGridView1.DataSource = Db.Customers.ToList();
        }

        private void CustWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Customers.ToList();
            dataGridView1.Columns[0].HeaderText = "Номер продажи";
            dataGridView1.Columns[1].Visible= false;
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Имя";
            dataGridView1.Columns[4].HeaderText = "Отчество";
            dataGridView1.Columns[5].HeaderText = "Серия паспорта";
            dataGridView1.Columns[6].HeaderText = "Номер паспорта";
            dataGridView1.Columns[7].HeaderText = "Телефон";
            dataGridView1.Columns[8].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Customers.ToList();
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
            dataGridView1.DataSource = Db.Customers.ToList();
        }

        private void имениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerLogic.GetOrderedCustomerName(Db);
        }

        private void фамилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerLogic.GetOrderedCustomerMiddleName(Db);
        }
    }
}
