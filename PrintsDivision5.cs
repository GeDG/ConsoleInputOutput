using System;

class PrintsDivision5
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(p(a,b));
    }
    static int p(int a, int b)
    {
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }

        }
        return count;
    }

}