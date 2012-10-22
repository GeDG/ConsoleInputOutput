using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a,b));
    }
}

