using System;

namespace Factory_Method.Products
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
           Console.WriteLine("Deliver Ship");
        }
    }
}