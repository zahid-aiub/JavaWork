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
    public partial class Admin : Form
    {
       
        public Admin()
        {
            InitializeComponent();
        }
        
        string uName;
        string uPass;
        //HomePage refer;

       
        public Admin(string uName,string uPass/*,HomePage refer*/)
        {
            this.uName = uName;
            this.uPass = uPass;
           /// this.refer = refer;

            InitializeComponent();


            
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            HomePage hp = new HomePage();
            hp.ShowDialog();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWork adw = new AdminWork();
            adw.ShowDialog();
        }

        private void deleteBookBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin_delete add = new Admin_delete();
            add.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowStudentList sl = new ShowStudentList(uName,uPass);
            sl.ShowDialog();
            
        }
    }
}
