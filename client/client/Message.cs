using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace client
{
    class Message
    {
        private WebSocketCom messanger;

        public void StartServer(string name)
        {
            messanger = new WebSocketCom(name);

        }

        public void SendMessage(string msg)
        {
            MessageEntered(msg);
        }

        public bool RecieveMessage(string message)
        {
            // Add message to messageListBox and scroll to bottom
            // Invoke is used to make sure that this is done in the GUI thread
            //Invoke(new Action(() => messageListBox.TopIndex = messageListBox.Items.Add(message)));
            MessageBox.Show(message);

            return true;
        }

        public bool MessageEntered(string message)
        {
            return messanger.MessageEntered(message);
        }
    }
}
