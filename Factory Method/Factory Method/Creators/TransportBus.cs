using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public class TransportBus : TransportCreator
    {
        public override ITransport CreateTransport()
        {
            return new Bus();
        }
    }
}