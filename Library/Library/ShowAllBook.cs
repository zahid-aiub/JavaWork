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
    public partial class ShowAllBook : Form
    {
        public ShowAllBook()
        {
            this.uId = "";
            this.uPass = "";
            InitializeComponent();
        }

        string uId;
        string uPass;
       // Login refer;

        public ShowAllBook(string uName,string uPass)
        {
            this.uId = uName;
            this.uPass = uPass;
            //this.refer = refer;

            InitializeComponent();
        }

        private void ShowAllBook_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)    //-->back button
        {
            this.SetVisibleCore(false);
             if (this.uId=="")
             {
                 HomePage hp = new HomePage();
                 hp.ShowDialog();
             }
             else
             {
                 Login lg = new Login(uId,uPass);
                 lg.ShowDialog();
             }
        }

       

        private void cseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CseStore cs = new CseStore(uId,uPass);
            cs.ShowDialog();
        }


        private void eeeBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            EeeStore es = new EeeStore(uId,uPass);
            es.ShowDialog();
        }

        private void bbaBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            BbaStore bs = new BbaStore(uId, uPass);
           bs.ShowDialog();
        }



        private void scBtn_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            ScStore scs = new ScStore(uId,uPass);
           scs.ShowDialog();
        }

        private void arBtn_Click(object sender, EventArgs e)  //--->> problem here
        {
            this.SetVisibleCore(false);
            ArcStore ars = new ArcStore(uId,uPass);
           ars.ShowDialog();
        }
    }
}
