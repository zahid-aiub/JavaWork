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
    public partial class Admin_cse : Form
    {
        public Admin_cse()
        {
            InitializeComponent();
        }

        private void Admin_cse_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminWork adwork = new AdminWork();
            adwork.ShowDialog();
        }
    }
}
