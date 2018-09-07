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
using System.IO;

namespace Library
{
    public partial class Add_ARC : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");
        string pwd = Class1.GetRandomPassword(20);
        string wanted_path;

        public Add_ARC()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWork ad = new AdminWork();
            ad.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Fill up all section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string img_path;
                    File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
                    img_path = "student_images\\" + pwd + ".jpg";
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //                
                    cmd.CommandText = "insert into arc_book values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + img_path.ToString() + "')";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Archetecture book added successfully...!!!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Exception Unhandeled...!");
                }
            }
        }
        
        private void Add_ARC_Load(object sender, EventArgs e)
        {

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
    }
}
