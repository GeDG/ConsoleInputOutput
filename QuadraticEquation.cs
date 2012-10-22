using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a coef = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b coef = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c coef = ");
        double c = double.Parse(Console.ReadLine());
        double root1, root2,D;
        D=b*b-4*a*c;
        Console.WriteLine(a + "x^2 + " + b + "x + " + c + "= 0");
        if (D < 0)
        {
            Console.WriteLine("No real roots");
            return;
        }
        else {
            root1 = (-b + Math.Sqrt(D)) / (2 * a);
            root2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("root1 = " + root1 + ", root2 = " + root2);
        }
    }
}

