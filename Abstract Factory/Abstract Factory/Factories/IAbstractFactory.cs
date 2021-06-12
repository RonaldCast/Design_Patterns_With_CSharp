using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }
}