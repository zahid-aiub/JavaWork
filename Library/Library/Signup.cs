
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class Signup : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;
        public Signup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string userId = textBox3.Text;
            string password = textBox4.Text;
            string id = textBox5.Text;

            if (name == "" || email == "" || userId == "" || password == "" || id =="")
            {
                MessageBox.Show("Fill up all section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(userId.Length > 5 && userId.Length < 12 && password.Length > 5 && password.Length < 10)
                    {
                        string img_path;
                        File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                        img_path = "student_images\\" + pwd + ".jpg";
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into student values('" + id + "','" + name + "','" + email + "','" + userId + "','" + password + "','" + img_path.ToString() + "')";
                        cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("record inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Follow sign up rules", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }

            
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif";
            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
