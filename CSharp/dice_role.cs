using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("Rolling Dice...\n");

        for (int i = 1; i <= 5; i++)
        {
            int dice = random.Next(1, 7);
            Console.WriteLine("Roll " + i + ": " + dice);
        }
    }
}