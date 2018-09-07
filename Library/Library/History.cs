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
    public partial class History : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");
        
        string userId;
        string userPass;

        public History(string id,string pass)
        {
            this.userId = id;
            this.userPass = pass;

            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Login wc = new Login(userId,userPass);
            wc.ShowDialog();
        }

        private void History_Load(object sender, EventArgs e)
        {
           disp_books();
          

        }
        public void disp_books()
        {
            con.Open();
            try
            {
               
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select book_name,quantity,department from history where username ='" + userId + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                
                textBox1.Text = row.Cells["book_name"].Value.ToString();
                textBox2.Text = row.Cells["department"].Value.ToString();
                
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="CSE")
            {
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update book set quantity=quantity+1 where book_name='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (textBox2.Text == "EEE")
            {
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update eee_book set quantity=quantity+1 where book_name='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (textBox2.Text == "BBA")
            {
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update bba_book set quantity=quantity+1 where book_name='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (textBox2.Text == "ARC")
            {
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update arc_book set quantity=quantity+1 where book_name='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (textBox2.Text == "SC")
            {
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update social_book set quantity=quantity+1 where book_name='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }


            //--------->> 
            //              Delete Book from History Table
            //--------->>

            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from history where username='" + userId.ToString() + "' and  book_name='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Retuened Successfully...!!!!!");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

            //--------->>>*********>>>--------->>>********>>>-----------
            /* try
             {
                 MySqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "select quantity from book where username='" + userId.ToString() + "'";
                 int x = cmd.ExecuteNonQuery();
                 x += 1;
                 disp_books();
                 //MessageBox.Show("RECORD UPDATED SUCCESSFULLY");

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             */
             disp_books();
     

        }
    }
}
