using System;
using System.Collections.Generic;

interface IAreaCalculator
{
    double CalculateTotalArea(IEnumerable<Shape> shapes);
}

class SimpleAreaCalculator : IAreaCalculator
{
    public double CalculateTotalArea(IEnumerable<Shape> shapes)
    {
        double totalArea = 0;
        foreach (var shape in shapes)
        {
            totalArea += shape.Area();
        }
        return totalArea;
    }
}

class AreaCalculatorClient
{
    private readonly IAreaCalculator _areaCalculator;

    public AreaCalculatorClient(IAreaCalculator areaCalculator)
    {
        _areaCalculator = areaCalculator;
    }

    public double GetTotalArea(IEnumerable<Shape> shapes)
    {
        return _areaCalculator.CalculateTotalArea(shapes);
    }
}

class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        IAreaCalculator areaCalculator = new SimpleAreaCalculator();
        AreaCalculatorClient areaCalculatorClient = new AreaCalculatorClient(areaCalculator);

        var shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        double totalArea = areaCalculatorClient.GetTotalArea(shapes);
        Console.WriteLine($"Total Area: {totalArea}");
    }
}
