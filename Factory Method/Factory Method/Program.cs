using System;
using Factory_Method.Creators;

namespace Factory_Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
                Client();
           
        }

        private static void Client()
        {
            Console.WriteLine("Elige un transporte");
            Console.WriteLine("1. Ship");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Plane");
            var number = Console.ReadLine();
           
            FactoryCreator factory;

            switch (number)
            {
                case "1": 
                    factory = new FactoryShip();
                    break;
                case "2": 
                    factory = new FactoryBus();
                    break;
                case "3": 
                    factory = new FactoryPlane();
                    break;
                default:
                    factory = new FactoryBus();
                    break;
            }

            var transport = factory.CreateTransport();
          
            transport.Deliver();
        } 
    }
}