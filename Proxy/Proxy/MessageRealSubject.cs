using System;

namespace Proxy
{
    public class MessageRealSubject : IMessageSubject
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}