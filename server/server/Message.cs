using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace server
{
    class Message
    {
        public void StartServer()
        {
            // Start a websocket server at port 8001
            var wss = new WebSocketServer(8001);

            // Add the Echo websocket service
            //wss.AddWebSocketService<Echo>("/echo");

            // Add the Chat websocket service
            //wss.AddWebSocketService<Chat>("/chat");

            wss.AddWebSocketService<WebsocketCom>("/chat");

            // Start the server
            wss.Start();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

            // Stop the server
            wss.Stop();
        }

        public void recieve(string message)
        {

        }

        public void RecievedBid(BidItem x, int pos)
        {

        }

        public void sendItems(List<BidItem> collection)
        {

        }
    }
}
