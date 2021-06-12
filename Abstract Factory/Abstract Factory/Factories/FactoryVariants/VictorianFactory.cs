using Abstract_Factory.Products;
using Abstract_Factory.Products.ProductVariants;

namespace Abstract_Factory.Factories.FactoryVariants
{
    
    public class VictorianFactory :  IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}