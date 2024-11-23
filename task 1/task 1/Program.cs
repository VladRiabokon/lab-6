using System;


internal class Program
{
    static double Func(double x, double y)
    {
        return (Math.Sinh(x) * Math.Tan(x + 1)) - Math.Pow(1 / Math.Tan(2 + Math.Sinh(x - 1)), 2);
    }

    static void Main()
    {
        double x = Func(-2.5, 0.5) + Func(0, 2) + Func(2, 5);
        Console.WriteLine("Значення функції: " + x);
    }
}



