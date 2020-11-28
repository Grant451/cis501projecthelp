using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace server
{
    class WebsocketCom : WebSocketBehavior
    {
        //this is where all the chats are saved:
        private static List<string> savedChats = new List<string>();

        //a list of all the saved users:
        private static List<string> savedUsers = new List<string>();

        protected override void OnMessage(MessageEventArgs e)
        {
            // Retrieve message from client
            string msg = e.Data;

            int len = msg.Length;
            int x = msg.IndexOf(" ");
            string chat = msg.Substring(x + 1);
            string usrname = msg.Substring(0, x);//this includes the ":" on the end.

            DateTime currenttime = DateTime.Now;//time stamp
            msg += " " + currenttime.Hour.ToString() + ":" + currenttime.Minute.ToString();

            if (!savedUsers.Contains(usrname))
            {
                savedUsers.Add(usrname);
                //send the user the saved chat data:
                //MessageBox.Show(Sessions.Sessions.ToString());
                //MessageBox.Show(usrname.Substring(0, usrname.IndexOf(":")));
                foreach (string prevmsg in savedChats)
                {//usrname.Substring(0, usrname.IndexOf(":"))
                    Sessions.SendTo(this.ID, prevmsg);//(id,msg)
                }
            }
            savedChats.Add(msg);

            // Broadcast message to all clients
            Sessions.Broadcast(msg);
        }

        public void updateclients()
        {

        }

        public void notifycontroller()
        {

        }

        public void MessageAllClients()
        {

        }

        public void MessageSingleClient()
        {

        }

        public void deserialize(string message)
        {

        }
    }
}
