using System;

public class Pentagon
{
    private double side;
    public Pentagon()
    {
        this.side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }
    public double GetPerimeter()
    {
        return 5 * side;
    }
    public double GetArea()
    {
        return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
    }

    public void Display(string p)
    {
        Console.WriteLine($"Pentagon {p}");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Side length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
        Console.WriteLine();
    }
    static void Main()
    {
        Pentagon p1 = new Pentagon();
        p1.Display("p1");

        Pentagon p2 = new Pentagon(5);
        p2.Display("p2");
    }
}