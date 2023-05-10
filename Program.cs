using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            //ввести дані про 10 різних фігур
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter shape {i + 1} data: ");
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter type (Circle or Square): ");
                string type = Console.ReadLine();

                if (type == "Circle")
                {
                    Console.Write("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(name, radius);
                    shapes.Add(circle);
                }
                else if (type == "Square")
                {
                    Console.Write("Enter side:");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(name, side);
                    shapes.Add(square);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Shapes:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
            //сортує 
            shapes.Sort();
            Console.WriteLine("Shapes sorted by area:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
            //пошук фігури з найбільшим периметром
            Shape shapeWithLargestPerimeter = shapes.OrderByDescending(shape => shape.Perimeter()).FirstOrDefault() as Shape;
            if (shapeWithLargestPerimeter == null)
            {
                Console.WriteLine("There is no shape with the largest perimeter.");
            }
            else
            {
                Console.WriteLine($"Shape with the largest perimeter: {shapeWithLargestPerimeter.Name}");
            }
        }
    }
}
