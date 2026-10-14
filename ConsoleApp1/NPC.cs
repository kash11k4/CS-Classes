using System;

namespace ConsoleApp1;

// Klasa NPC
public class NPC
{
    // Deklaracije
    public string Name;
    public string armor;
    private int health;

    // Konstruktor
    public NPC(string name, string armor, int health)
    {
        this.Name = name;
        this.armor = armor;
        this.health = health;  
    }

    // Getter
    public int GetHealth()
    {
        return health;
    }

    // Setter
    public void SetHealth(int health)
    {
        this.health = health;
    }

}
