using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Component
    {
       private List<Component> _children = new List<Component>();
        
        public Directory(string name) : base(name)
        {
        }


        public void AddChild(Component child)
        {
            _children.Add(child);
        }

        public void RemoveChild(Component child)
        {
            _children.Remove(child);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var child in _children)
            {
               child.Display(depth + 1);
            }
        }
    }
}