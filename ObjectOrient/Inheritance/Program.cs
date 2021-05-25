using System;
namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            //Base Class Constructor
            //----------------------
            BaseClass bc = new BaseClass();

            //Base Class Constructor
            //----------------------
            //First Child Class Constructor
            //----------------------
            FirstChildClass fc = new FirstChildClass();

            // Base Class Constructor
            //----------------------
            //First Child Class Constructor
            //----------------------
            BaseClass bcfc = new FirstChildClass();

            // Base Class Constructor
            //  ----------------------
            // First Child Class Constructor
            // ----------------------
            //Second Child Class Constructor
            //----------------------
            SecondChildClass sc = new SecondChildClass();

            //Base Class Constructor
            // ----------------------
            //First Child Class Constructor
            // ----------------------
            //Second Child Class Constructor
            //----------------------
            FirstChildClass scfc = new SecondChildClass();

            // Below throws error as child class instance cannot be created on base class object
            //FirstChildClass fcbc = new BaseClass();

            bc.Print();
            fc.Print();
            bcfc.Print();
            scfc.Print();


            /* Output
             * Base Class Print
            ----------------------
            First Child Class Print
            ----------------------
            Base Class Print
            ----------------------
            First Child Class Print
            ---------------------- */
        }
    }
}
