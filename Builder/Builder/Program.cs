using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonHouseBuilder commonHouseBuilder = new CommonHouseBuilder();
            
            DirectorHouse directorHouse = new DirectorHouse();
            directorHouse.HouseBuilder = commonHouseBuilder;
            directorHouse.BuildFullHouse();
            
            //Full Home
            var house =  commonHouseBuilder.GetHouse();
             Console.WriteLine( house.ListPart());
             Console.WriteLine();
             
            //Simple Home 
             commonHouseBuilder.Reset();
             directorHouse.BuildHouseSimple();
             house = commonHouseBuilder.GetHouse();
             Console.WriteLine(house.ListPart());
             Console.WriteLine();
             
             //Custom Home
            commonHouseBuilder.Reset();
            commonHouseBuilder.AddGarden();
            commonHouseBuilder.AddPool();
            house = commonHouseBuilder.GetHouse();
            Console.WriteLine(house.ListPart());
        }
    }
}