using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {
        public static healthItem potion1 = new healthItem("Industrial Healing Potion", "An industrial healing potion. Tastes terrible, but is a small price to pay for not bleeding out.", 5, 3, 5);
        public static healthItem potion2 = new healthItem("Flask of Gator Venom", "A flask of diluted Gator Venom. Gnarly stuff. Floridian Gators are built different.", 5, 3, -5);
        public static healthItem potion3 = new healthItem("You don't want to know", "Don't ask about it. Just throw it at something you don't want to exist anymore.", 10, 8, -20);
        public static healthItem potion1G = new healthItem("Dangerously Concentrated Caffiene", "Students live and die by the cocktail in this brew. It might shorten your lifespan, but you'll be energetic up till the end!", 3, 1, 4);
        public static healthItem potion2G = new healthItem("An Essay with a Failing Grade", "Emotional Damage!", 1, 0, -3);
        public static Armor armor1G = new Armor(1, "Paper Armor", "This set of armor has been fortified with past student essays. You look like a walking typo, but it's better protection than nothing.", 6, 3, false);
        public static Armor gahunklefopperArmor = new Armor(2, "Gahunklefopper's Armor", "Gahunklefopper's Armor is made of sturdy plates of steel. It'd be beautiful, if it wasn't several sizes too small for you. It's a proper pain to get into, but hey, protection is protection.", 0, 0, false);
        public string name;
        public string description;
        public int shopPrice;
        public int sellPrice;

        public Item(string name, string description, int shopPrice, int sellPrice)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.sellPrice = sellPrice;
        }

        public abstract void Use(Entity user, Entity target);

    }
    
    class healthItem : Item
    {
        public int healAmount;

        public healthItem(string name, string description, int shopPrice, int sellPrice, int healAmount) : base(name, description, shopPrice, sellPrice)
        {
            this.healAmount = healAmount;
        }

        public override void Use(Entity user, Entity target)
        {
            target.currentHP += this.healAmount;
            Console.WriteLine(target.name + " recovered " + this.healAmount + " HP!");
        }
    }
}
