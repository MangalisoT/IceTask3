namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", 384, 89);
            Circle circle = new Circle("Circle", 700);
     
            rectangle.Display();
            Console.WriteLine();  // Print a blank line
            circle.Display();

            Console.ReadLine();
        }
    }
}
