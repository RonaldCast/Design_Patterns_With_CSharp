using System;

namespace Factory_Method.Products
{
    public class Plane : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver Plane");
        }
    }
}