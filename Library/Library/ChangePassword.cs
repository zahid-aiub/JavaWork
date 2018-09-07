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
    public partial class ChangePassword : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");


        string uName;
        string uPass;
        Login refer;

        public ChangePassword(string name,string pass, Login refer)
        {
            this.uName = name;
            this.uPass = pass;
            this.refer = refer;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //----->> Back Button
            this.Hide();
            Login lg = new Login(uName,uPass);
            lg.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                string currentPass = textBox1.Text;
            string newPass = textBox2.Text;
            string confirmPass = textBox3.Text;

            if (currentPass=="" || newPass=="" || confirmPass=="")
            {
                MessageBox.Show("Fill up all section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (uPass == currentPass)
                {
                    if (confirmPass == newPass)
                    {
                        if (confirmPass.Length > 5 && confirmPass.Length < 10)
                        {
                            try
                            {
                                con.Open();
                                MySqlCommand cmd = con.CreateCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE student SET password = '" + confirmPass + "' WHERE username ='" + uName + "'";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Password has been changed.");
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                //Login    ----->>>comeback
                                this.Hide();
                                HomePage hp = new HomePage();
                                hp.ShowDialog();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password length must be between 6 to 9.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Confirm password doesn't match with new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Current password is incorrect..!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
