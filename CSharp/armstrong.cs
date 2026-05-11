using System;

class Program
{
    static void Main()
    {
        int num, sum = 0, digit, temp;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        temp = num;

        while (temp != 0)
        {
            digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }

        if (sum == num)
            Console.WriteLine(num + " is an Armstrong Number");
        else
            Console.WriteLine(num + " is not an Armstrong Number");
    }
}