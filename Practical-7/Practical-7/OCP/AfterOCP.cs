using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.OCP
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double totalArea = 0;

            foreach (Shape shape in shapes)
            {
                totalArea += shape.Area();
            }

            return totalArea;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
                {
                    new Rectangle
                    {
                        Width = 5, Height = 4
                    },
                    new Circle
                    {
                        Radius = 3 } };

            AreaCalculator calculator = new AreaCalculator();
            double totalArea = calculator.TotalArea(shapes);

            Console.WriteLine("Total area: " + totalArea);
        }
    }
}
