using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public abstract class FactoryCreator
    {
        public abstract ITransport CreateTransport();
    }
}