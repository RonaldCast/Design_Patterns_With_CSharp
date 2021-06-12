using System;
using Abstract_Factory.Factories;
using Abstract_Factory.Factories.FactoryVariants;
using Abstract_Factory.Products;

namespace Abstract_Factory
{
    class Program
    {
       public static void Main(string[] args)
        {
            VictorianFactory myFactory = new VictorianFactory();
            BuyFurniture(myFactory);
            Console.ReadKey();
        }


        private static void BuyFurniture(IAbstractFactory factory)
        {
           IChair chair =  factory.CreateChair();
           ITable table = factory.CreateTable();
           
           chair.GetLegs();
           table.GetLegs();
        }
    }
}