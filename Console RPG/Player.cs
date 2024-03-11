using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Player : Entity
        {
            public static List<Item> inventory = new List<Item>();
            public static int Money = 0;
            public int plotArmor;
            public Player (string name, int hp, int mana, Stats stats, int plotArmor, List<string> inventory) : base(name, hp, mana, stats)
            {
                this.plotArmor = plotArmor;
            }
            
            public static string GetName(Entity entity)
            {
                return (entity.name);
            }
            public override Entity ChooseTarget(List<Entity> choices)
            {
            Console.WriteLine("Pick a victim!");
                for (int i = 0; i < choices.Count; i++)
                    {
                        Console.WriteLine(i + ":" + choices[i].name);
                    }
                int index = Convert.ToInt32(Console.ReadLine());
                return choices[index];
            }
            public Item ChooseItem(List<Item> choices)
            {
                Console.WriteLine("Pick an item number!");
                for (int i = 0; i < choices.Count; i++)
                {
                    Console.WriteLine(i + ":" + choices[i].name);
                }
                int index = Convert.ToInt32(Console.ReadLine());
                return choices[index];
            }

            public override void Attack(Entity target)
            {
                target.currentHP = target.currentHP - this.stats.attack;
                Console.WriteLine($"{this.name} attacked {target.name} for {this.stats.attack}! {target.name} is now at {target.currentHP}!");
            }
            public override void DoTurn(List<Player> players, List<Enemy> enemies)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1:ATTACK | 2:USE ITEM ON ENEMIES | 3:USE ITEM ON SELF");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                    Attack(target);
                }
                else if (choice == "2")
                {
                    Item item = ChooseItem(inventory);
                    Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                    UseItem(item, target);
                    inventory.Remove(item);
                }
                else if (choice == "3")
                {
                    Item item = ChooseItem(inventory);
                    Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                    UseItem(item, target);
                    inventory.Remove(item);
                }

        }
            
            public void UseItem(Item item, Entity target)
            {
                item.Use(this, target);
            }
        
    }
}
