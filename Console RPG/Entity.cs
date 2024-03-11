using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Console_RPG
{
    abstract partial class Entity
    {
        public string name;
        public float currentHP, maxHP;
        public float currentMana, maxMana;

        public Stats stats;

        public Entity(string name, float hp, float mana, Stats stats)
        {
            this.name = name;
            this.currentHP = hp;
            this.maxHP = hp;
            this.currentMana = mana;
            this.maxMana = mana;
            this.stats = stats;
        }
        public abstract void DoTurn(List<Player> players, List<Enemy> enemies);
        public abstract Entity ChooseTarget(List<Entity> choices);
        public abstract void Attack(Entity target);
    }
        //-------------------------------------------------------------------------------------------------------
        class Enemy : Entity
        {
            public int moneyDropped;
            public Item lootDropped;

            public Enemy(string name, int hp, int mana, Stats stats, int moneyDropped, Item lootDropped) : base(name, hp, mana, stats)
            {
                this.moneyDropped = moneyDropped;
                this.lootDropped = lootDropped;
            }
            
            public override Entity ChooseTarget(List<Entity> choices)
            {
                Random random = new Random();
                return choices[random.Next(0, choices.Count)];
            }
            public override void DoTurn(List <Player> players, List<Enemy> enemies)
            {
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                Attack(target);
            }

            public override void Attack(Entity target)
            {
               target.currentHP = target.currentHP - this.stats.attack;
               Console.WriteLine($"{this.name} attacked {target.name} for {this.stats.attack}! {target.name} is now at {target.currentHP}!");
            }
        }
    }

