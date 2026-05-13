using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(number, 2);

        Console.WriteLine("Binary Equivalent: " + binary);
    }
}