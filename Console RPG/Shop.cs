using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    internal class Shop : LocationFeature
    {
        public string vendorName;
        public List<Item> items;

        public Shop(string vendorName, List<Item> items) : base(false)
        {
            this.vendorName = vendorName;
            this.items = items;
        }
        public override void Resolve(List<Player> players)
        {
            
            Console.WriteLine($"Welcome to {vendorName}! Buy something! Please! The Economy's in dire straits!");
            while (true) 
            {
                Console.WriteLine($"1:BUY | 2:LEAVE | You have {Player.Money}");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Item item = ChooseItem(this.items);
                    if (item.shopPrice < Player.Money)
                    {
                        Player.Money -= item.shopPrice;
                        Player.inventory.Add(item);
                        Console.WriteLine($"You got a {item.name}");
                    }
                    else if (item.shopPrice > Player.Money)
                    {
                        Console.WriteLine("You're too poor! Those student debts really caught up with you, huh?");
                    }
                }
                else if (input == "2")
                {
                    break;
                }
            }
                Console.WriteLine("Thanks for the money! Come back soon! Or don't! I don't care! This is my last day!");
            //Spend the money
            //Get the item
            //Tell the user they have the item
        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Pick an item!");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i}:{choices[i].name} (${choices[i].shopPrice}");
            }
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index];
        }
    }
}
