using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    // inherriting from abstract class shape
    // you must use abstract class to inherrit from it, or you will get an error
    class Circle : Shape
    {
        // create radius property
        public double Radius { get; set; }

        // constructor
        public Circle(double radius)
        {
            // Refference name and shape
            Name = "Circle";
            Radius = radius;
        }

        // using abstract class from abstract class, Shape
        // automatically generated when adding Shape inheritance and
        // clicking on error (underlined in red 'Circle') then click
        // on error poppup, to add method with throw
        public override double Area()
        {
            // originally generated throw
            //throw new NotImplementedException();
            // instead, calculate area
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        // You can replace the method using override
        // we are overiding GetInfo, that is a method inside
        // of the Shape class
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            // add this to the base getinfo
            Console.WriteLine($"It has a Radius of {Radius}");
        }

    }
}
