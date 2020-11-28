/*Grant Clothier
 * this controls the GUI for the server admin
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

namespace server
{
    public partial class ServerForm : Form
    {
        //used to check if the credentials where correct.
        public bool auth = false;

        //holds an instance of auctioncontrol so that Items can be adjusted
        private AuctionControl auction;

        //holds the list of strings that mirrors the items list in bid items
        private List<string> items = new List<string>();

        //holds an instance of message to send messages
        private Message sender = new Message();

        public ServerForm()
        {
            //on startup it should fill the 
            var login = new LoginControl();
            login.loadcred();
            var cred = getloginstring();
            if(login.checkcredentials(cred))
            {
                auth = true;
                sender.StartServer();
                InitializeComponent();
                auction = new AuctionControl();
            }
            else
            {
                //login info is invalid exit the program.
                MessageBox.Show("Invalid credentials");
                auth = false;
                //System.Windows.Forms.Application.Exit();
                //this.Close();
            }
        }

        /// <summary>
        /// this uses login view to collect login information from the user
        /// </summary>
        /// <returns>the string</returns>
        private string[] getloginstring()
        {
            var logininfo = new string[2];
            var credentials = new loginview();
            using (credentials)
            {
                var result = credentials.ShowDialog();
                logininfo[0] = credentials.logininfo[0];
                logininfo[1] = credentials.logininfo[1];
            }
            return logininfo;
        }

        /// <summary>
        /// when this button is clicked an Item is added to items list
        /// and all the clients are updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string itemname = auction.AddItem();
            if(!(itemname.CompareTo("")==0))
            {
                items.Add(itemname);
                lstItems.Items.Clear();
                foreach (string x in items)
                {
                    lstItems.Items.Add(x);
                }
            }
        }
    }
}
