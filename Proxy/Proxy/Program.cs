using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageRealSubject messageRealSubject = new MessageRealSubject();
            messageRealSubject.SendMessage("Hola");
            
            MessageProxy proxy = new MessageProxy(messageRealSubject);
            
            proxy.SendMessage("Hola, Como estas?");
            
            
        }
    }
}