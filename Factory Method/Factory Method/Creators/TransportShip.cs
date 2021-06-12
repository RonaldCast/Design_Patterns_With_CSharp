using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public class TransportShip : TransportCreator
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}