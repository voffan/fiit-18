using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rental
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void b_Clients_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Clients.ToList();
            }
        }

        private void b_Disks_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Disks.ToList();
            }
        }

        private void b_Movies_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Movies.ToList();
            }
        }

        private void b_Orders_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Orders.ToList();
            }
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            AddForm ad = new AddForm();
            ad.ShowDialog();
        }

        private void b_Rental_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                dataGridView1.DataSource = db.Rentals.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int _id = (int)dataGridView1.Rows[index].Cells[3].Value;
            using (EditClass ec = new EditClass())
            {
                ec.DeleteClient(_id);
            }
        }

        private void b_Edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int _id = (int)dataGridView1.Rows[index].Cells[3].Value; 
            AddForm ad = new AddForm(_id);
            System.Console.WriteLine(_id);
            ad.ShowDialog();
        }
    }
}
