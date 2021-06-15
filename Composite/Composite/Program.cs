using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory root = new Directory("Escritorio");

            var doc = new Directory("doc");
            doc.AddChild(new Leaf("sdsd.txt"));
            doc.AddChild(new Leaf("tnsname.txt"));
            
            var app = new Directory("Applicaction");
            app.AddChild(new Leaf("hola.html"));
            doc.AddChild(app);
            
            root.AddChild(doc);
            root.AddChild(new Directory("Ronald"));
            root.Display(1);
            Console.ReadKey();
        }
    }
}