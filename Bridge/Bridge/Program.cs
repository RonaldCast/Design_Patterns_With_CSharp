
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RefinedAbstractionDevice refinedAbstractionDevice = new RefinedAbstractionDevice();
            ConcreteImplementorDevice concreteImplementorDevice = new ConcreteImplementorDevice();
            refinedAbstractionDevice.ImplementorDevice = concreteImplementorDevice;
            ConcreteImplementorDevice concreteImplementorDevice1 = new ConcreteImplementorDevice();

            Console.WriteLine( refinedAbstractionDevice.GetVolume());
            Console.WriteLine( concreteImplementorDevice1.GetVolume());

        }
    }
}