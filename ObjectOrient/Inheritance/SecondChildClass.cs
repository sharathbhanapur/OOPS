using System;
namespace Inheritance
{
    public class SecondChildClass : FirstChildClass
    {
        public SecondChildClass()
        {
            Console.WriteLine("Second Child Class Constructor");
            Console.WriteLine("----------------------");
        }
        public new void Print()
        {
            Console.WriteLine("Second Child Class Print");
            Console.WriteLine("----------------------");
        }
    }
}
