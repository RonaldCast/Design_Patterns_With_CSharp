using System;

namespace Abstract_Factory.Products.ProductVariants
{
    public class VictorianChair : IChair
    {
        public void GetLegs()
        {
            Console.WriteLine("Silla: 4 patas victoriana");
        }
    }
}