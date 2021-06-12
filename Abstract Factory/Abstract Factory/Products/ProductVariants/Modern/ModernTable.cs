using System;

namespace Abstract_Factory.Products.ProductVariants
{
    public class ModernTable : ITable
    {
        public void GetLegs()
        {
            Console.WriteLine("Mesa: 4 patas modernas");
        }
    }
}