using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square square1 = new Square("Red", 34);
        Circle circle1 = new Circle("Blue", 78);
        Rectangle rectangle1 = new Rectangle("Green", 90, 45);

        Shapes.Add(square1);
        Shapes.Add(circle1);
        Shapes.Add(rectangle1);

        foreach (Shape shape in Shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has the area of {area}");
        }
    
    }
}