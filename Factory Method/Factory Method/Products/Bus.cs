using System;

namespace Factory_Method.Products
{
    
    public class Bus : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver Bus");
        }
    }
}