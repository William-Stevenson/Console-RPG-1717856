using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public static Location Gatorgankers = new Location("Gatorgankers", "The Gatorgankers franchise is the premier budget magic shop in all of Florida. This store is run by a depressed looking teenager wearing a wrinkled uniform.", new Shop("Gatorgankers", new List<Item>() { Item.potion1, Item.potion2, Item.potion3 } ));
        public string name;
        public string description;
        public LocationFeature feature;
        public Location north, east, south, west;

        public Location(string name, string description, LocationFeature feature)
        {
            this.name = name;
            this.description = description;
            this.feature = feature;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            if (!(north is null))
            {
                north.south = this;
            }
            if (!(south is null))
            {
                this.south = south;
                south.north = this;
            }
            if (!(east is null))
            {
                this.east = east;
                east.west = this;
            }
            if (!(west is null))
            {
                this.west = west;
                west.east = this;
            }
        }

            public void Resolve()
            {
                Console.WriteLine("You find yourself in " + this.name);
                Console.WriteLine(this.description);

            if (!(this.north is null))
            {
                Console.WriteLine("North: " + this.north.name);
            }
            if (!(this.west is null))
            {
                Console.WriteLine("West: " + this.west.name);
            }
            if (!(this.east is null))
            {
                Console.WriteLine("East: " + this.east.name);
            }
            if (!(this.south is null))
            {
                Console.WriteLine("South: " + this.south.name);
            }
            string direction = Console.ReadLine();
            Location nextLocation = null;
            if(direction == "North")
            {
                nextLocation = this.north;
            }
            if (direction == "South")
            {
                nextLocation = this.south;
            }
            if (direction == "East")
            {
                nextLocation = this.east;
            }
            if (direction == "West")
            {
                nextLocation = this.west;
            }
        
            
            
          
        }
    }
}
