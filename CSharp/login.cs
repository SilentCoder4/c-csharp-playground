using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (username == "admin" && password == "1234")
            Console.WriteLine("Login Successful");
        else
            Console.WriteLine("Invalid Username or Password");
    }
}