using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatManager" in both code and config file together.
    [ServiceContract]
    public interface IChatManager
    {
        [OperationContract]
        void SendMessage(string message);
        [OperationContract]
        List<string> GetMessages();
    }
}
