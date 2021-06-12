using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public abstract class TransportCreator
    {
        public abstract ITransport CreateTransport();
    }
}