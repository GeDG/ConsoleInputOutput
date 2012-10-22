using System;

class AllNumbersToN
{
    static void Main()
    {
        Console.WriteLine("Enter number n");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i == n) {
                Console.WriteLine(i);
                break;
            }
            Console.Write(i + ", ");
        }
    }
}

