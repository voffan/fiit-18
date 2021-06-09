using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class SchoolEditForm : Form
    {
        public Context Db { get; set; }
        public School School { get; set; }
        public SchoolEditForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SchoolLogic.EditSchool(Db, this.School.Id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            //this.School.Name = textBox1.Text;
            //this.School.Address = textBox2.Text;
            //this.School.Email = textBox3.Text;
            //this.School.Phone = textBox4.Text;
            //Db.Entry(this.School).State = EntityState.Modified;
            //Db.SaveChanges();
            MessageBox.Show("Запись изменена");
            this.Close();
        }

        private void SchoolEditForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.School.Name;
            textBox2.Text = this.School.Address;
            textBox3.Text = this.School.Email;
            textBox4.Text = this.School.Phone;

        }

    }
}
