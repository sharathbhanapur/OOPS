using System;
using Polymorphism;

namespace PolymorphismConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CompileTimePolyMorphism cp = new CompileTimePolyMorphism();
            RunTimePolyMorphism rp ;

            Console.WriteLine("Compile Polymorphism - " + cp.Multiply(2, 5));
            Console.WriteLine("Compile Polymorphism - "+ cp.Multiply(8.5, 10.5));

            Console.WriteLine("----------------------------------------");

            rp = new Subclass1();
            Console.WriteLine(rp.Print());

            rp = new Subclass2();
            Console.WriteLine(rp.Print()); 
           
        }
    }
}
