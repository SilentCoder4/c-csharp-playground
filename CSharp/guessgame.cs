using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 101);
        int guess;

        Console.WriteLine("Guess the number between 1 and 100");

        do
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > secret)
                Console.WriteLine("Too high!");
            else if (guess < secret)
                Console.WriteLine("Too low!");

        } while (guess != secret);

        Console.WriteLine("Correct! You guessed the number.");
    }
}