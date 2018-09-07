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
    public partial class Delete_cse : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");

        public Delete_cse()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_delete ad = new Admin_delete();
            ad.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----------
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE from book where book_name = '" + textBox1.Text + "'";
                int x = cmd.ExecuteNonQuery();
                if (x==1)
                {
                    MessageBox.Show("CSE book deleted successfully...!!!");
                }
                else
                {
                    MessageBox.Show("Book not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                textBox1.Clear();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
