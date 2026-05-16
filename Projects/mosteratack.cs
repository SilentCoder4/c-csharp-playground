using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int health = 100;

        Console.WriteLine("=== Monster Attack Game ===");

        while (health > 0)
        {
            int damage = random.Next(5, 21);

            health -= damage;

            if (health < 0)
                health = 0;

            Console.WriteLine("Monster attacked! Damage: " + damage);
            Console.WriteLine("Health Left: " + health);
            Console.WriteLine();
        }

        Console.WriteLine("Game Over!");
    }
}