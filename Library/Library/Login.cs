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
    public partial class Login : Form
    {
        string uId;
        string uPass;
        //HomePage hr;

        public Login(string uName, string Pass/*,HomePage hr*/)
        {
            this.uId = uName;
            this.uPass = Pass;
           // this.hr = hr;

            InitializeComponent();

            
            
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void searchBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAllBook sab = new ShowAllBook(uId,uPass);
            sab.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword cp = new ChangePassword(uId,uPass,this);
            cp.ShowDialog();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewHistoryBTN_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            History ht = new History(uId, uPass);
            ht.ShowDialog();

        }
    }
}
