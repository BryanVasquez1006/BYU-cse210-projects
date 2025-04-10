using System;

class Program
{
    static void Main(string[] args)
    {
        Square square= new Square(2);
        string color = square.GetColor();
        double squareArea = square.GetArea();
        Console.WriteLine($"The square color is {color} and the area is {squareArea}");


        Rectangle rectangle = new Rectangle(4, 5);
        string rectangleColor = rectangle.GetColor();
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"the rectangle color is {rectangleColor} and the rectangle area is {rectangleArea}");

        Circle circle = new Circle(4);
        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();
        Console.WriteLine($"The circle color is {circleColor} and the area {circleArea}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach(Shape shape in shapes)
        {
            string shapeColor = shape.GetColor();
            double shapeArea = shape.GetArea();

            Console.WriteLine($"{shapeColor} {shapeArea}");
        }

    }
}