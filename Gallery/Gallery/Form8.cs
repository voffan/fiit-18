using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
        }

        static void AddEx(string name, string country, string city, DateTime date)
        {
            using (System.Data.SqlClient.SqlConnection con = new SqlConnection(
            ))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Exhibition VALUES(@Weight, @Name, @Breed)", con))
                    {
                        command.Parameters.Add(new SqlParameter("Weight", weight));
                        command.Parameters.Add(new SqlParameter("Name", name));
                        command.Parameters.Add(new SqlParameter("Breed", breed));
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    Console.WriteLine("Count not insert.");
                }
            }
        }
    }
}
