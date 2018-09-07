/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=library;User Id=root;password=''");

        MySqlCommand command;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addstudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string insertQuery = "insert into student1 (id,name,discription,image)VALUSE(@id,@name,@desc,@img)";


            parameters[0] = new MySqlParameter("ID", MySqlDbType.VarChar, 20);
            parameters[0].Value = textBoxID.Text;

            parameters[1] = new MySqlParameter("Name", MySqlDbType.VarChar, 200);
            parameters[1].Value = textBoxNAME.Text;

            parameters[2] = new MySqlParameter("Description", MySqlDbType.Text);
            parameters[2].Value = textBoxDescription.Text;

            parameters[3] = new MySqlParameter("Image", MySqlDbType.LongBlob);
            parameters[3].Value = img;

            command = new MySqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Add_Data";
            command.Connection = connection;
            command.Parameters.AddRange(parameters);
            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("OK");
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
*/