using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat
{
    public partial class index : System.Web.UI.Page
    {
        List<string> messages;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["messagesRoom1"] == null)
                Application["messagesRoom1"] = new List<string>();
            messages = (List<string>)Application["messagesRoom1"];
        }

        void UpdateMessages()
        {
            //Pega mensagens novas no ServiceQueue
            while (!ServiceQueue.GetInstance().IsEmpty())
            {
                string message = ServiceQueue.GetInstance().GetMessage();
                messages.Add(message);
            }

            //Atualiza na interface
            lbMessages.Text = "";
            foreach (var message in messages)
            {
                lbMessages.Text += message + "</br>";
            }
        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            /*
            ChatManager.ChatManagerClient chatManagerClient = new ChatManager.ChatManagerClient();
            chatManagerClient.Open();
            chatManagerClient.SendMessage(txtMessage.Text);
            chatManagerClient.Close();
            */

            string nickname = Session["nickname"] as string;
            string message = nickname + ": " + txtMessage.Text;

            //Coloca a mensagem na fila única
            ServiceQueue.GetInstance().AddMessage(message);

            UpdateMessages();
            txtMessage.Text = "";
            txtMessage.Focus();
        }

        /*
        protected void UpdateMessages()
        {
            ChatManager.ChatManagerClient chatManagerClient = new ChatManager.ChatManagerClient();
            chatManagerClient.Open();
            List<string> messages;
            messages = chatManagerClient.GetMessages();
            chatManagerClient.Close();

            labelMessages.Text = "";
            foreach(var message in messages)
            {
                labelMessages.Text += "<br><img src='" + message + "' />";
            }
        }*/

        protected void timerRefresher_Tick(object sender, EventArgs e)
        {
            UpdateMessages();
            txtMessage.Focus();
        }
    }
}