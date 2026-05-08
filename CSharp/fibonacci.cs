using System;

class Program
{
    static void Main()
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");

            next = first + second;
            first = second;
            second = next;
        }
    }
}