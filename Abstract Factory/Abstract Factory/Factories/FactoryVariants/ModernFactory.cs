using Abstract_Factory.Products;
using Abstract_Factory.Products.ProductVariants;

namespace Abstract_Factory.Factories.FactoryVariants
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}