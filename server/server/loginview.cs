using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Login : Form
    {
        //used to store the login info
        public string[] logininfo = new string[2];

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //build the string array and return it to the auction controller:
            //var logininfo = new string[2] { txtusername.Text.ToString(), txtPassword.Text.ToString() };
            logininfo[0] = txtusername.Text.ToString();
            logininfo[1] = txtPassword.Text.ToString();
            this.Close();
        }

        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(790, 607);
            this.Name = "Login";
            this.ResumeLayout(false);

        }*/
    }
}
