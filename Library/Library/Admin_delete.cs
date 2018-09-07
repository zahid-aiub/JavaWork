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
    public partial class Admin_delete : Form
    {
        public Admin_delete()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.ShowDialog();

        }

        private void Admin_delete_Load(object sender, EventArgs e)
        {

        }

        private void CSEbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_cse dcse = new Delete_cse();
            dcse.ShowDialog();
        }

        private void EEEbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_EEE dcse = new Delete_EEE();
            dcse.ShowDialog();
        }

        private void BBAbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_BBA dcse = new Delete_BBA();
            dcse.ShowDialog();
        }

        private void ARCbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_ARC dcse = new Delete_ARC();
            dcse.ShowDialog();
        }

        private void SCbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_SC dcse = new Delete_SC();
            dcse.ShowDialog();
        }
    }
}
