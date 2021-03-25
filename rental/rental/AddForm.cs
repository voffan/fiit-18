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
    public partial class AddForm : Form
    {
        public bool isClientnew = true;
        public int edit_id;
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(int _id)
        {
            InitializeComponent();
            Edit_mode(_id);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            using (EditClass ec = new EditClass())
            using (ApplicationContext db = new ApplicationContext())
            {
                
                int _id;
                if (isClientnew == true)
                {
                    _id = db.Clients.DefaultIfEmpty().Max(r => r == null ? 0 : r.Id);
                    _id++;
                }
                else
                    _id = edit_id;
                ec.AddClient(_id, textBox1.Text, textBox2.Text, textBox3.Text, 0);
            }
            isClientnew = false;
            this.Close();
        }

        private void Edit_mode(int _id)
        {
            using (EditClass ec = new EditClass())
            using (ApplicationContext db = new ApplicationContext())
            {
                edit_id = _id;
                isClientnew = false;
                Client client = new Client();
                client = db.Clients.Find(_id);
                textBox1.Text = client.FullName;
                textBox2.Text = client.PhoneNumber;
                textBox3.Text = client.Email;
                db.Clients.Remove(client);
                db.SaveChanges();
            }
        }
    }
}
