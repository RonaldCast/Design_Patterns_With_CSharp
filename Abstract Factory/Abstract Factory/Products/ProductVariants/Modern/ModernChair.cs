using System;

namespace Abstract_Factory.Products.ProductVariants
{
    public class ModernChair : IChair
    {
        public void GetLegs()
        {
            Console.WriteLine("Silla: 4 patas modernas");
        }
    }
}