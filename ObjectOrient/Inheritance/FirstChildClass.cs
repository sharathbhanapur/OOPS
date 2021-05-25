using System;
namespace Inheritance
{
    public class FirstChildClass : BaseClass
    {
        public FirstChildClass()
        {
            Console.WriteLine("First Child Class Constructor");
            Console.WriteLine("----------------------");
        }
        public new virtual void Print()
        {
            Console.WriteLine("First Child Class Print");
            Console.WriteLine("----------------------");
        }
    }
}
