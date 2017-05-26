using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebChat
{
    interface IServiceQueue
    {
        void AddMessage(string message);
        string GetMessage();
        bool IsEmpty();
    }
}
