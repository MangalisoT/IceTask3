using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    //Derived Class
    internal class Circle : AbstractShape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
             return Math.PI * Radius * Radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine();
            Console.WriteLine($"Radius: {Radius} \nCircle Area: {CalculateArea():F2}");
        }
    }
}
