using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat
{
    public class ServiceQueue : IServiceQueue
    {
        static ServiceQueue uniqueInstance;
        static Queue<string> messages = new Queue<string>();

        public static ServiceQueue GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new ServiceQueue();
            return uniqueInstance;
        }

        public void AddMessage(string message)
        {
            messages.Enqueue(message);
        }

        public string GetMessage()
        {
            return messages.Dequeue();
        }

        public bool IsEmpty()
        {
            if (messages.Count == 0)
                return true;
            return false;
        }
    }
}