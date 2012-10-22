using System;

class CalculateSum
{
    static void Main()
    {
        decimal sum = 1;
        for (decimal i = 2; i < 500; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + (1 / i);
            }
            else 
            {
                sum = sum - (1 / i);
            }
        }   
        Console.WriteLine("Sum = " + sum);
    }
}

