using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public class FactoryShip : FactoryCreator
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}