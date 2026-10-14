using System;

namespace ConsoleApp1;

public class Goblin : NPC
{
 // Vars
    public string race;
    private string racialAbility;

    // Konstruktor
    public Goblin(string name, string armor, int health) : base(name, armor, health)
    {
          this.race = "Goblin";
          this.racialAbility = "Bolestan";
    }

    // Talk method
    public void Talk()
    {
        Console.WriteLine("bolestan prica");
    }

    public void alterAbility(string newAbility)
    {
        racialAbility = newAbility;
    }

    public string getAbility()
    {
        return racialAbility;
    }
}
