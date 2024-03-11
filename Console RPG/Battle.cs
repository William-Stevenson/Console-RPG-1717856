using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle : LocationFeature
    {
        public List<Enemy> enemies;
        public int moneyDrop;
        
        public Battle(List<Enemy> enemies, int moneyDrop) : base(false)
        {
            this.enemies = enemies;
            this.moneyDrop = moneyDrop;
        }

        public override void Resolve(List<Player> players)
        {
            //Loop the turn system
            while (true)
            {
                //Loop through players
                foreach (var player in players)
                {
                    if (player.currentHP > 0)
                    {
                        Console.WriteLine("It is " + player.name + "'s turn");
                        player.DoTurn(players, enemies);
                    }
                }
                if (enemies.TrueForAll(enemy => enemy.currentHP <= 0))
                {
                    Console.WriteLine("Skill success, you're not trash!");
                    Console.WriteLine($"Foes defeated! You gain {moneyDrop} dollars!");
                    Player.Money += moneyDrop;
                    foreach (var enemy in enemies)
                    {
                        Player.inventory.Add(enemy.lootDropped);
                    }
                    break;
                }
                foreach (var enemy in enemies)
                {
                    if (enemy.currentHP > 0)
                    {
                        Console.WriteLine($"It is {enemy.name}'s turn.");
                        enemy.DoTurn(players, enemies);
                    }
                }
                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("YOU HAVE PERISHED! Florida claims another soul.....");
                    Environment.Exit(0);
                    break;
                }
                
            }
        }
    }
}
