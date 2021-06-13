using System;

namespace Prototype
{
    public class Robot : RobotPrototype
    {
        public  string Color { get; set; }
        public  string Name { get; set; }
        public  DateTime CreatedDate { get; }

        public Robot(string color, string name)
        {
            Color = color;
            Name = name;
            CreatedDate = DateTime.Now;
        }
        
        public override RobotPrototype CloneRobot()
        {
            return MemberwiseClone() as RobotPrototype;
        }

        public void Greet()
        {
            Console.WriteLine($"I'm {Name}");
        }
    }
}