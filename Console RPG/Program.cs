using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity cracklord = new Entity("Sir Crackhead the Second", 1, 35, new Stats(attack: 10, defense: 0, magicModifier: 20, magicResistance: 0));
            Entity player = new Entity("Floridaman", 10, 10, new Stats(attack: 5, defense: 2, magicModifier: 1, magicResistance: 0));
            Console.WriteLine(cracklord.stats.magicModifier);
            Console.WriteLine("Welcome to Fantasy Floridaman! Please punch in your name:");

        }
    }
}
