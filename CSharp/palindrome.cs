using System;

class Program
{
    static void Main()
    {
        int num, reversed = 0, remainder, original;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        original = num;

        while (num != 0)
        {
            remainder = num % 10;
            reversed = reversed * 10 + remainder;
            num /= 10;
        }

        Console.WriteLine("Reversed Number: " + reversed);

        if (original == reversed)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}