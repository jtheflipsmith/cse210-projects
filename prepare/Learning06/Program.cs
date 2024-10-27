using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");
        Square square = new Square("green", 6);
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("blue", 13, 6);
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("yellow", 5);
        Console.WriteLine(circle.GetArea());


    }
}