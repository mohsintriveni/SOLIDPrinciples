using System;

public interface IShape
{
    double Area();
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

public class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }
}

public class Triangle : IShape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double Area()
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);
        IShape triangle = new Triangle(3, 7);

        Console.WriteLine($"Circle Area: {circle.Area()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
        Console.WriteLine($"Triangle Area: {triangle.Area()}");
    }
}
