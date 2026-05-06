using System;

class PasswordGenerator
{
    static void Main()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        Random random = new Random();

        for (int i = 0; i < 8; i++)
        {
            Console.Write(chars[random.Next(chars.Length)]);
        }
    }
}