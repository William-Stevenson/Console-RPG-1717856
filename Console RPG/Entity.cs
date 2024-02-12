using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Entity
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

        public abstract Entity ChooseTarget(List<Entity> choices);
        public abstract void Attack(Entity target);
        
        //---------------------------------------------------------------------------------------------------------
        class Player : Entity
        {
            public int plotArmor;
            public Player (string name, int hp, int mana, Stats stats, int plotArmor) : base(name, hp, mana, stats)
            {
                this.plotArmor = plotArmor;
            }
            public override Entity ChooseTarget(List<Entity> choices)
            {
                Random random = new Random();
                return choices[random.Next(0, choices.Count)];
            }

            public override void Attack(Entity target)
            {
                Console.WriteLine(this.name + " attacked " + target.name + "!");
            }
        }
        //-------------------------------------------------------------------------------------------------------
        class Enemy : Entity
        {
            public int moneyDropped;
            public string lootDropped;

            public Enemy(string name, int hp, int mana, Stats stats, int moneyDropped, string lootDropped) : base(name, hp, mana, stats)
            {
                this.moneyDropped = moneyDropped;
                this.lootDropped = lootDropped;
            }

            public override Entity ChooseTarget(List<Entity> choices)
            {
                Random random = new Random();
                return choices[random.Next(0, choices.Count)];
            }

            public override void Attack(Entity target)
            {
                Console.WriteLine(this.name + " attacked " + target.name + "!");
            }
        }
    }
}
