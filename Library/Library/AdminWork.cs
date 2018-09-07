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
    public partial class AdminWork : Form
    {
        public AdminWork()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin hp = new Admin();
            hp.ShowDialog();
        }
        
        private void cseBtn_Click(object sender, EventArgs e)
        {
            //----------------------------
            this.Hide();
            // Admin_cse adcse = new Admin_cse();
            Add_cse acse = new Add_cse();
            acse.ShowDialog();
        }

        private void eeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_EEE adeee = new Add_EEE();
            adeee.ShowDialog();

            //Admin_cse adcse = new Admin_cse();
            // AdminWork adw = new AdminWork();
           // Delete_cse dl = new Delete_cse();
            //dl.ShowDialog();
        }

        private void bbaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_BBA ad = new Add_BBA();
            ad.ShowDialog();
            /*this.Hide();
            Admin_cse adcse = new Admin_cse();
            adcse.ShowDialog();

            */

        }

        private void arcBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_ARC ad = new Add_ARC();
            ad.ShowDialog();

            /*this.Hide();
            Admin_cse adcse = new Admin_cse();
            adcse.ShowDialog();
            */
        }

        private void socBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_SC ad= new Add_SC();
            ad.ShowDialog();
            /*this.Hide();
            Admin_cse adcse = new Admin_cse();
            adcse.ShowDialog();
            */
        }
    }
}
