using Factory_Method.Products;

namespace Factory_Method.Creators
{
    public  class FactoryPlane : FactoryCreator
    {
        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}