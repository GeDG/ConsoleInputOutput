using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers");
        int numbers = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Next number = ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("number = "+number);
            sum = sum + number;
            Console.WriteLine("Sum of numbers = "+sum);
        }
    }
}

