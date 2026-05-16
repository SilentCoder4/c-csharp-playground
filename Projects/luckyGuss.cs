using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int lucky = random.Next(1, 11);
        int guess;

        Console.WriteLine("=== Lucky Number Game ===");
        Console.Write("Guess a number between 1 and 10: ");

        guess = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lucky Number: " + lucky);

        if (guess == lucky)
            Console.WriteLine("Jackpot! You Won!");
        else
            Console.WriteLine("Try Again!");
    }
}