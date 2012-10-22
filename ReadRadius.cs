using System;

    class ReadRadius
{
    static void Main()
    {
        Console.WriteLine("Enter radius");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter = " + (Math.PI * 2 * r));
        Console.WriteLine("Area = " + (Math.PI * r * r)); 
    }
}

