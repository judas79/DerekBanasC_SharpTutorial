using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasC_SharpTutorial
{
    class Rectangle : Shape
    {
        // create rectangle property fields
        public double Length { get; set; }
        public double Width { get; set; }

        // constructor
        public Rectangle(double length,
            double width)
        {
            // Refference
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        // overide Area method in abstract class shape
        public override double Area()
        {
            return Length * Width;
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version specific for a rectangle
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and Width of {Width}");
        }
    }
}
