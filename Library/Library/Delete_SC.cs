using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Delete_SC : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");


        public Delete_SC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_delete ad = new Admin_delete();
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = "DELETE from social_book where book_name = '" + textBox1.Text + "'";

                }
                catch
                {
                    MessageBox.Show("Please give correct name of book...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cmd.ExecuteNonQuery();

                MessageBox.Show("Book not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                con.Close();
          
        }
    }
}
