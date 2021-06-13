using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gallery
{
    public partial class EmployeeWin : Form
    {

        public string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DB;Integrated Security=True";
        public Context Db { get; set; }
        public EmployeeWin()
        {
            InitializeComponent();
        }

        private void EmployeeWin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
            dataGridView1.Columns[0].HeaderText = "Отдел";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Статус";
            dataGridView1.Columns[5].HeaderText = "Фамилия";
            dataGridView1.Columns[6].HeaderText = "Имя";
            dataGridView1.Columns[7].HeaderText = "Отчество";
            dataGridView1.Columns[8].HeaderText = "Серия паспорта";
            dataGridView1.Columns[9].HeaderText = "Номер паспорта";
            dataGridView1.Columns[10].HeaderText = "Контактный телефон";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpAdd empAdd = new EmpAdd();
            empAdd.Db = this.Db;
            empAdd.ShowDialog();
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[4, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Employee ex = EmployeeLogic.GetEmpById(Db, id);

                EmpRed form = new EmpRed(id, ex.Name, ex.Surname, ex.Middle_Name, ex.Passport_id, ex.Passport_series, ex.Phone, ex.Position, ex.DepId, ex.Status);
                form.Db = this.Db;
                form.ShowDialog();
            }
            dataGridView1.Refresh();
            dataGridView1.DataSource = Db.Employees.ToList();
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
                        bool converted = Int32.TryParse(dataGridView1[4, index].Value.ToString(), out id);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Db.Employees.ToList();
        }

        private void имениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT *FROM dbo.Person ORDER BY Name", connection);
                DataSet ds = new DataSet();
                command.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];          
            }

        }

        private void фамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT *FROM dbo.Person ORDER BY Surname", connection);
                DataSet ds = new DataSet();
                command.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void отделуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT *FROM dbo.Person ORDER BY DepId", connection);
                DataSet ds = new DataSet();
                command.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {

=======
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
>>>>>>> 206add5514af616bbcc46c71d9519a7f36147aaa
        }
    }
}
