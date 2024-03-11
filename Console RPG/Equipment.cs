using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Equipment : Item
    {
        public bool isEquipped;

        protected Equipment(string name, string description, int shopPrice, int sellPrice, bool isEquipped) : base(name, description, shopPrice, sellPrice)
        {
            this.isEquipped = isEquipped;
        }
    }
    class Armor : Equipment
    {
        public int defense;

        public Armor(int defense, string name, string description, int shopPrice, int sellPrice, bool isEquipped) : base(name, description, shopPrice, sellPrice, isEquipped)
        {
            this.defense = defense;
        }
        public override void Use(Entity user, Entity target)
        {
            if (this.isEquipped)
            {
                target.stats.defense -= this.defense;
                this.isEquipped = false;
                Console.WriteLine($"You've unequipped {this.name}!");
            }
            else
            {
                target.stats.defense += this.defense;
                this.isEquipped = true;
                Console.WriteLine($"You've equipped {this.name}!");
            }
        }
    }
    class Weapon : Equipment
    {
        public int damageMultiplier;

        public Weapon(int damageMultiplier, string name, string description, int shopPrice, int sellPrice, bool isEquipped) : base(name, description, shopPrice, sellPrice, isEquipped)
        {
            this.damageMultiplier = damageMultiplier;
        }
        public override void Use(Entity user, Entity target)
        {
            if (this.isEquipped)
            {
                target.stats.attack -= this.damageMultiplier;
                this.isEquipped = false;
                Console.WriteLine($"You've unequipped {this.name}!");
            }
            else
            {
                target.stats.attack += this.damageMultiplier;
                this.isEquipped = true;
                Console.WriteLine($"You've equipped {this.name}!");
            }
        }

    }
    
}
