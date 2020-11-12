using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class loginview : Form
    {
        //used to store the login info
        public string[] logininfo = new string[2];

        public loginview()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            logininfo[0] = txtusername.Text.ToString();
            logininfo[1] = txtpassword.Text.ToString();
            this.Close();
        }
    }
}
