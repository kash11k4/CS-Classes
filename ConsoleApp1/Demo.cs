using System;

namespace ConsoleApp1;

public class Demo
{

    public static void Main(string[] args)
    {
        // Create a Human object
        Human human = new Human("John", "Leather Armor", 100);

        // Call the Talk method
        human.Talk();

        // Display health using getter
        Console.WriteLine($"{human.Name}'s health: {human.GetHealth()}");

        // Change health using setter
        human.SetHealth(80);
        Console.WriteLine($"{human.Name}'s new health: {human.GetHealth()}");

        // Display health using getter
        Console.WriteLine($"{human.Name}'s health: {human.GetHealth()}");
    }

}
