using System;

namespace ConsoleApp1;

// Klasa Human inherits from NPC class
public class Human : NPC
{
    // Vars
    public string race;
    private string racialAbility;

    // Konstruktor
    public Human(string name, string armor, int health) : base(name, armor, health)
    {
          this.race = "Human";
          this.racialAbility = "Adaptability";
    }

    // Talk method
    public void Talk()
    {
        Console.WriteLine($"{Name} says: Hello, I am a {race} with the ability of {racialAbility}.");
    }
}