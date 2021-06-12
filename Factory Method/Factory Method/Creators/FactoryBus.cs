using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public class FactoryBus : FactoryCreator
    {
        public override ITransport CreateTransport()
        {
            return new Bus();
        }
    }
}