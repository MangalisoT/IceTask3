using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    //Base Class
    class AbstractShape
    {
        //Property/s:
        public string Name { get; set; }

        public AbstractShape(string name)
        {
            this.Name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
