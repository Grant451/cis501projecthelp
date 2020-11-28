﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace client
{
    class WebSocketCom
    {
        private string name;
        private WebSocket ws;

        // Event for when a message is received from the server
        //public event Message RecieveMessage;


        public WebSocketCom(string name)
        {
            this.name = name;

            // Connects to the server
            ws = new WebSocket("ws://127.0.0.1:8001/chat");
            //ws.OnMessage += (sender, e) => { if (RecieveMessage != null) RecieveMessage(e.Data); };
            ws.Connect();
        }

        // Handles when a new message is entered by the user
        public bool MessageEntered(string message)
        {
            // Send the message to the server if connection is alive
            if (ws.IsAlive)
            {
                ws.Send(name + ": " + message);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Makes sure to close the websocket when the controller is destructed
        ~WebSocketCom()
        {
            ws.Close();
        }
    }
}
