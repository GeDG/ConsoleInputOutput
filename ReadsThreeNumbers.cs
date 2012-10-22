using System;

class ReadsThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number one = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number two = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number three = ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (a + b + c));
    }
}

