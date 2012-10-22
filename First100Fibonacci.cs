using System;

    class First100Fibonacci
    {
        static void Main()
        {
            ulong a = 0;
            ulong b = 1;
            for (int i = 2; i < 50; i++)
            {
                a = b +a;
                b = a + b;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }

