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
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            //on startup it should fill the 
            var login = new LoginControl();
            login.loadcred();
            MessageBox.Show("finished");
            InitializeComponent();
        }
    }
}
