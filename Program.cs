using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the side length of the cube: ");
        double side = double.Parse(Console.ReadLine());

        double length = CalculateLength(side);
        double width = CalculateWidth(side);
        double height = CalculateHeight(side);

        Console.WriteLine("The length of the cube is: {0}", length);
        Console.WriteLine("The width of the cube is: {0}", width);
        Console.WriteLine("The height of the cube is: {0}", height);

        Console.ReadKey();
    }

    static double CalculateLength(double side)
    {
        return side;
    }

    static double CalculateWidth(double side)
    {
        return side;
    }

    static double CalculateHeight(double side)
    {
        return side;
    }
}