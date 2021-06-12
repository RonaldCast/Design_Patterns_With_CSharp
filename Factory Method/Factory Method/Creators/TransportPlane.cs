using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public  class TransportPlane : TransportCreator
    {
        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}