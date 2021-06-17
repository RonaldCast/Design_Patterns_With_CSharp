using System;

namespace Proxy
{
    public class MessageProxy : IMessageSubject
    {
        private MessageRealSubject _messageReal;

        public MessageProxy(MessageRealSubject model)
        {
            _messageReal = model;
        }
        
        private void OtherProccess()
        {
            Console.WriteLine("Message send through Proxy");
        }
        
        public void SendMessage(string message)
        {
            OtherProccess();
            _messageReal = _messageReal ??= new MessageRealSubject();
            _messageReal.SendMessage(message);
        }
    }
}