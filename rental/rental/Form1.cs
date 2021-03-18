using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace rental
{
    public partial class Form1 : Form
    {
        ApplicationContext db = new ApplicationContext();
        public Form1()
        {
            InitializeComponent();
            using (EditClass ec = new EditClass())
            {
               // ec.Addbutton()
               // Добавляет в базу данных экспериментального клиента
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void b_Clients_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clients.ToList();
        }

        private void b_Disks_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Disks.ToList();
        }

        private void b_Movies_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Movies.ToList();
        }

        private void b_Orders_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EditClass ec = new EditClass())
            {
                ec.Addbutton();
            }
        }
    }
}
