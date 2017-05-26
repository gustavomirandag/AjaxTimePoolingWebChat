using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatManager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChatManager.svc or ChatManager.svc.cs at the Solution Explorer and start debugging.
    public class ChatManager : IChatManager
    {
        public List<string> GetMessages()
        {
            return WebRole.messages;
        }

        public void SendMessage(string message)
        {
            WebRole.messages.Add(message);
        }
    }
}
