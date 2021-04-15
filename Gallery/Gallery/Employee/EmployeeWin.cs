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
    public partial class EmployeeWin : Form
    {
        public Context Db { get; set; }
        public EmployeeWin()
        {
            InitializeComponent();
        }

        private void EmployeeWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpAdd empAdd = new EmpAdd();
            empAdd.Db = this.Db;
            empAdd.ShowDialog();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
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

                        EmployeeLogic.DelEmp(Db, id);

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
            dataGridView1.DataSource = Db.Employees.ToList();
      
    }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
