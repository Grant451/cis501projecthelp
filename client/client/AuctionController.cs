/*Grant Clothier 11/11
 * this is the client used to control auction operations for the users
 */
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
    public partial class AuctionController : Form
    {
        //public delegate void somemethodptr();
        /*static void Main(string[] args)
         * {
         *  somemethodeptr obj = new somemethodeptr(somemethod);
         *  obj.invoke();
         *  }
         *  static void somemethod(){};
         */

        //the controller will have a private message instance:
        private Message messanger;

        public AuctionController()
        {
            //call a methode to validate the login credentials:
            //MessageBox.Show("help");
            var logininfo = getloginstring();
            //create a request to the server to see if the login info is valid:

            //check login***

            //set the username to the name:
            string name = logininfo[0];

            //spool up server
            messanger = new Message();
            messanger.StartServer(name);

            InitializeComponent();
        }

        /// <summary>
        /// this uses login view to collect login information from the user
        /// </summary>
        /// <returns>the string</returns>
        private string[] getloginstring()
        {
            var logininfo = new string[2];
            var credentials = new Login();
            using (credentials)
            {
                var result = credentials.ShowDialog();
                logininfo[0] = credentials.logininfo[0];
                logininfo[1] = credentials.logininfo[1];
            }
            return logininfo;
        }

        private void txtdemosend_Click(object sender, EventArgs e)
        {
            messanger.SendMessage(txtdemomessage.Text);
        }

        
    }
}
