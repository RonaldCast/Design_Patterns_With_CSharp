using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot realRobot = new Robot( "Red", "Andrews");
            Robot  clone = realRobot.CloneRobot() as Robot;
            clone.Name = "Pedro";
            Console.WriteLine($"{realRobot.Name} Date Create: {realRobot.CreatedDate}. \n I'm clone {clone.Name} Date Create: {clone.CreatedDate}");
            
            Console.ReadKey();
        }
    }
}