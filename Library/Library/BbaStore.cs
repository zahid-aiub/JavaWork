using MySql.Data.MySqlClient;
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

namespace Library
{
    public partial class BbaStore : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");
        
        public string uName;
        string uPass;

        public BbaStore(string name, string pass)
        {
            this.uName = name;
            this.uPass = pass;

            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bba_book where book_name like('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            ShowAllBook sb = new ShowAllBook(uName, uPass);
            sb.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            HomePage hm = new HomePage();    //-->> defined at the top
            hm.ShowDialog();
        }

        private void BbaStore_Load(object sender, EventArgs e)
        {
            if (uName == "" && uPass == "")
            {
                borrowBtn.Visible = false;
                b_id_text.Visible = false;
                b_name_text.Visible = false;
                author_text.Visible = false;
                edition_text.Visible = false;
                quantity_text.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }

            disp_books();
            
        }
        public void disp_books()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bba_book";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;



                con.Close();
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

                //id_text.Text = row.Cells["Id"].Value.ToString();
                b_id_text.Text = row.Cells["book_id"].Value.ToString();
                b_name_text.Text = row.Cells["book_name"].Value.ToString();
                author_text.Text = row.Cells["author_name"].Value.ToString();
                edition_text.Text = row.Cells["edition"].Value.ToString();
                quantity_text.Text = row.Cells["quantity"].Value.ToString();
                textBox3.Text = row.Cells["department"].Value.ToString();
                textBox2.Text = quantity_text.Text;
                int c = Convert.ToInt32(textBox2.Text);
                c = c - 1;
                textBox2.Text = c.ToString();
            }
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            int x = 1;
            if (quantity_text.Text == x.ToString())
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT into history SET username = '" + uName + "', book_name= '" + b_name_text.Text + "',quantity='" + quantity_text.Text + "',department = '" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Borrowed Successfully....!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    //con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update bba_book set quantity='" + textBox2.Text + "'where book_name='" + b_name_text.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    disp_books();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You can't borrow more than ONE book at a time...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void quantity_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}

