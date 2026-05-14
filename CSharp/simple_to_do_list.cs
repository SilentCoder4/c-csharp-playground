using System;

class Program
{
    static void Main()
    {
        string[] tasks = new string[5];

        Console.WriteLine("Simple To-Do List");

        for (int i = 0; i < tasks.Length; i++)
        {
            Console.Write("Enter task " + (i + 1) + ": ");
            tasks[i] = Console.ReadLine();
        }

        Console.WriteLine("\nYour Tasks:");

        foreach (string task in tasks)
        {
            Console.WriteLine("- " + task);
        }
    }
}