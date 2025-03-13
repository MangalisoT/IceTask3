using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShapeAreaCalculator
{
    //Derived Class
    internal class Rectangle: AbstractShape, ICalculateArea
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle(string name, double length, double width) : base(name)
        {
            this.Length = length;
            this.Width = width;
        }
        public double CalculateArea()
        {
            return Length * Width;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine();
            Console.WriteLine($"Length: {Length} \nWidth: {Width}\nRectangle Area: {CalculateArea():F2}");      
        }


    }
}
