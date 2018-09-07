using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;

namespace Library
{
    public partial class HomePage : Form 
    {
         MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");
       
        public HomePage()
        {
            InitializeComponent();
        }
        string uId;
        string uPass;

        public HomePage(string uName, string uPass)
        {
            this.uId = uName;
            this.uPass = uPass;
        }

            private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            ShowAllBook sb = new ShowAllBook("","");
            sb.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Signup su = new Signup();
            su.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Login your original Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string userName = textBox1.Text;
                string userPass = textBox2.Text;

                //this.SetVisibleCore(false);
                if (userPass.Length == 5)
                {
                    try
                    {

                        int i = 0;
                        con.Open();

                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from admin where a_id='" + userName + "' and a_pass='" + userPass + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());

                        if (i == 0)
                        {
                            MessageBox.Show("Eeeor..!!! Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // textBox1.Clear();
                            textBox2.Clear();
                        }

                        else
                        {
                            //MessageBox.Show("Admin login successfully");
                            this.Hide();
                            // AdminWork adw = new AdminWork();
                            Admin ad = new Admin(userName, userPass);
                            ad.ShowDialog();

                        }

                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error..!!! Connection doesn't Established.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {

                    try
                    {
                        int i = 0;
                        con.Open();

                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from student where username='" + userName + "' and password='" + userPass + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        i = Convert.ToInt32(dt.Rows.Count.ToString());
                        
                        if (i == 0)
                        {
                            MessageBox.Show("Eeeor..!!! Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // textBox1.Clear();
                            textBox2.Clear();
                        }

                        else
                        {
                            this.Hide();
                            Login lg2 = new Login(userName, userPass /*, this*/);
                            lg2.ShowDialog();

                        }

                        con.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error..!!!Connection doesn't Established.");
                    }

                }
            }
            
           
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
