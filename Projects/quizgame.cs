using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("=== Simple Quiz Game ===");

        Console.WriteLine("What is the capital of France?");
        Console.Write("Answer: ");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "paris")
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong Answer!");
        }

        Console.WriteLine("Final Score: " + score);
    }
}