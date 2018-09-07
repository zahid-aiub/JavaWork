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
    public partial class ShowStudentList : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");


        string uName;
        string uPass;
        public ShowStudentList(string name,string pass)
        {
            this.uName = name;
            this.uPass = pass;

            InitializeComponent();
        }

        private void ShowStudentList_Load(object sender, EventArgs e)
        {
            disp_books();
        }
        public void disp_books()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student";
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

                
               textBox1.Text = row.Cells["name"].Value.ToString();
               textBox2.Text = row.Cells["email"].Value.ToString();
               textBox3.Text = row.Cells["username"].Value.ToString();
                
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where username like('%" + textBox4.Text + "%')";
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
            this.Hide();
            Admin ad = new Admin(uName, uPass);
            ad.ShowDialog();
        }
    }
}
