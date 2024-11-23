using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть послідовність чисел (0 для завершення):");
        ReverseSequence();
    }

    static void ReverseSequence()
    {
        int number = int.Parse(Console.ReadLine());

        if (number != 0)
        {
            ReverseSequence();
            Console.WriteLine(number);
        }
    }
}