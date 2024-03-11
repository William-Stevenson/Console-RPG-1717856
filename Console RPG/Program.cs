using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gahunklefoppersWrath = false;
            Enemy borderGuard1 = new Enemy("Border Guard 1", 5, 0, new Stats(3, 0, 0, 1), 0, Item.potion1);
            Enemy borderGuard2 = new Enemy("Border Guard 2", 5, 0, new Stats(3, 0, 0, 1), 0, Item.potion1);
            Enemy angryHopper = new Enemy("Gahunklefopper of Vengance", 3, 0, new Stats(4, 0, 0, 0), 0, Item.potion1);
            Enemy angryGundalf = new Enemy("Gahunklefopper of Vengance", 2, 0, new Stats(4, 0, 0, 0), 0, Item.potion1);
            Enemy beatCop = new Enemy("Beat Cop", 3, 0, new Stats(1, 0, 0, 0), 5, null);
            Shop gatorgankers = new Shop("Gatorgankers", new List<Item> { Item.potion1G, Item.potion2G, Item.armor1G });
            Console.WriteLine("Welcome to Fantasy Floridaman! Please punch in your name:");
            List<string> inventory = new List<string>(); Player player = new Player(Console.ReadLine(), 10, 0, new Stats(2, 1, 0, 0), 2, inventory);
            Console.WriteLine("Lovely! Your name is " + player.name + ", right?");
            Console.WriteLine("1:YES | 2:NO");
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "1")
                {
                    Console.WriteLine("Oh, that's unfortunate. Your parents must've really hated you, huh?");
                    break;
                }
                else if (input == "2")
                {
                    Console.WriteLine("Oh man, that's a relief. I thought your panrents hated you. It's too late to change your answer though, so we're gonna have to live with it.");
                    break;
                }
                else
                {
                    Console.WriteLine("Input not recongized! Please type the number of the option you choose.");

                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Right then, let's get to it. I'm Lenny, your narrarator. You are " + player.name + ", a wizard fresh out of Florida's premier magic college, 'The Stanlo University of Various Magiks and Whatnots: Covering Spells, Scrolls, and Gnolls' ranked 25th in the country. All the locals just call it TSUVMW:CSSG or 'That hippie school'.");
            Console.WriteLine("You placed exactly in the middle of your class. Everyone below your grade returned to college for additional schooling. Everyone above you has been hired already. Joining the military is a no-go, as it has a nasty habit of turning wizards into battle mages, and that is absloutely not what you majored in.");
            Console.WriteLine("Instead, your only hope is to ESCAPE FLORIDA. 10 years ago, the rest of the US erected a magical barrier around the whole of Florida after the failure of the 17th Gator Reclamation Crusade. Anarchy reigns supreme. Wildlife is increasingly hostile. Everyone's too busy taking drugs and getting eaten by gators to adress the drug and gator problem. In other words, it's not that different from normal Florida.");
            Console.WriteLine("You have a lead. The local Elder, Gundalf, was part of the barrier creation spell. He might know a way to bypass it. Travel to: 1:GUNDALF'S HOUSE?");
            Location gundalfHouse = new Location("Gundalf's House", "The Elderly Wizard's house is a vaguely posh suburb home, with what appears to be a pond in the backyard. The light blue paint covering the house is currently being touched up by an animated paintbrush and bucket.", null);
            input = Console.ReadLine();
            bool gundalfWrath = false;
            if (input == "1")
            {
                gundalfHouse.Resolve();
                Console.WriteLine("At you approach the front door, you hear a muffled shout from within the house. 'GIT OFF MA LAWN! I'VE GOT NUFFIN' ERE FOR YA!'. You ignore him and: 1:KNOCK ON THE DOOR | 2:BLOW UP THE DOOR");
                input = Console.ReadLine();
            }

            if (input == "2")
            {
                Console.WriteLine("Good thing you took that pyromancy class as an elective! Concentrating for a second, you channel the ambient heat of the Floridian summer into the palm of your hand. The air around you gets colder as the ball of fire in your hand siphons the heat from the environment to grow larger. You take a step back, and hurl the fireball into Gundalf's door.");
                Console.WriteLine("'OH MA GOD WHY' Are Gundalf's last words for the day as the projectile formerly known as a door catapults directly into his face.");
                Console.WriteLine("Seeing your chance to snoop around, you gingerly step around the unconcious wizard, and proceed deeper into the house as sirens begin to wail in the background..");
                gundalfWrath = true;
            }
            else if (input == "1")
            {
                Console.WriteLine("You gently knock on the door. You hear a clatter and general ruckus inside as Gundalf stumbles to the door and pushes it open.");
                Console.WriteLine("'Cantcha hear an ol' man when he tells yas to bugger off?' Gundalf abruptly quiets down and stares straight into your soul.");
                Console.WriteLine("'Wait, wait. Did yous graduate from good ol TSUVMW:CSSG? Oh boah! It's been a heckuva long time since anyone from TSUVMW:CSSG came to see me for guydance!'. Gundalf, with suprising strength, grabs you by the arm and tows you inside insistently, sitting you down in a crusty old armchair. He proceeds to regale you with tales from 'Da gud ol days', not letting you get a single word in edgewise. Eventually, after a gruelling 30 minutes, he dozes off in a fitful slumber. Seeing your chance to snoop, you proceed deeper into the house.");
            }
            Console.WriteLine("1:STUDY");
            input = Console.ReadLine();


            if (input == "1")
            {
                Console.WriteLine("You enter Gundalf's study. It's an old room, but well used. Lit only by a window and neumerous candels, it's actuaslly supremely cozy. After searching for a little bit, you find what you were looking for: Gundalf's journal. Inside, you find the entry written the day the Great Floridian Barrier was erected.");
                Console.WriteLine("1:READ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("'January 15th, 2014. The dome has been constructed. It's a sight to behold. A purple. shimmering, iridescent bubble of magic. It's beautiful, really. A shame it dooms everyone in Florida to a lifetime of being trapped here. Oh well, they'll probably be fine. I know I will! The government gave me the deed to this sick new house as a reward for my work.'");
                    Console.WriteLine("The journal continues: 'It's a fool proof protection, really. The only way to break through the barrier is with a collection of 2 exceedingly mediocre items carried by one exceedingly mediocre person. They must be absolutely mundane in relation to the items around them, but not mundane in general. A good item would be a magical sword in an armory full of masterwork swords and swords of pure evil. Just... just a magical sword. Why take the boring one when you could have Drangsutr, Slayer of Giants? Oh well, no use speculating. No one's ever gonna break free. I'm just here to enjoy my retirement.'");
                    Console.WriteLine("Well, that's about as clear as it'll get. You move to the armory, in search of an exceedingly unremarkable weapon.");
                    Console.WriteLine("1:Armory");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("Walking upstairs, you set your eyes upon Gundalf's legendary Arcane Armory. You gaze flows past Gundalf's Mossberg 501, used to slay the Gator Lord Galanthurg. The Ancient Discombobulator, destroyer of the evil mage Kalatross. Even the BIG BOAH, a machine spellgun accredited with felling the Anaconda Swarms of 1999 via a hail of fireballs! Truly a display of raw power. A shame it's locked up. The only weaponry freely available is the mere Glockinator, a weapon barely capable of defeating a disgruntled mosquito. It's not even worth using as a weapon instead of your Wandomatic 359. This means it is the PERFECT mediocre item. Scratch one off your list!");
                    }
                }
            }

            Player.inventory.Add(Item.potion1);
            Console.WriteLine("Feeling confident that you've aquired everything of use, you stash the Glockinator in your bag and walk out of the house.");
            if (gundalfWrath == true)
            {
                Console.WriteLine("As you step through the still smoking doorway, you're greeted with the wailing of police sirens.");
                Console.WriteLine("A police woman stand squarely in front of you, blue uniform shining in the midday sun. The Beat Cop begins to shout. 'You are under arrest! Step forward with your hands in the air!'");
                Console.WriteLine("It seems your wanton destruction of property hasn't gone unoticed! Get ready for a fight!");
                Enemy houseCop = new Enemy("Beat Cop", 5, 0, new Stats(1, 0, 0, 0), 3, Item.potion2);
                Battle houseBattle = new Battle(new List<Enemy> { houseCop }, 8);
                houseBattle.Resolve(new List<Player> { player });
                Console.WriteLine("Holy crap, you just knocked that cop out. Best skeddadle before the rest of them show up! But where to?");
                Console.WriteLine("You could pop back to 'The Stanlo University of Various Magiks and Whatnots: Covering Spells, Scrolls, and Gnolls' and ransack the library of arcane artefacts. You could also brave the ruins of Miami and search for anything mediocre in nature. Once you go down a path, there will be no turning back.");
            }
            else
            {
                Console.WriteLine("You walk downstairs, and casually step out of the doorway. As Gundalf's snores fade into the distance, you think on where to go next.");
                Console.WriteLine("You could pop back to 'The Stanlo University of Various Magiks and Whatnots: Covering Spells, Scrolls, and Gnolls' and ransack the library of arcane artefacts. It's your best bet.");
                Console.WriteLine("Travel to: 1: TSUVMW:CSSG?");
    
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("You begin to walk the familiar road down to your old school. The early morning crispness gives way to a midday stagnant heat. Nothing like home, huh?");
                    Console.WriteLine("After an hour, you finally arrive at TSUVMWCSSG.");
                    Console.WriteLine("The school's modestly sized gate swings open to reveal a moderately sized brick building full of decent enough students. It's a shame that you can't pick up the entire school and bring it to the barrier. Still, it should be easy enough to find something somewhat more portable in the library.");
                    Console.WriteLine("Unfortunately, the only way for alumni to gain access to the library is through... A WIZARD'S DUEL. Thankfully, it's against Mr. Gahunklefopper, the oldest professor on campus. It shoudlnt' be too difficult. Right? You can also stop by the student store to prepare a little.");
                    Console.WriteLine("1: LIBRARY | 2: STUDENT STORE");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("You make your way to the library entrance. Get ready for a fight!");
                        Console.WriteLine("As you aproach the library, a guard stops you. 'ID, please?'");
                        Console.WriteLine("You flash your former student ID card, and the guard pales. 'Here to fight old Gahunklefopper, eh? Gotta say, I don't envy you.'");
                        Console.WriteLine("The guard gestures to a seat, and you sit down and wait. Then you wait some more. Your nerves give way to abject boredom. Everntually, a whole *hour* later, a hunched old man with a cane totters his way towrds you. Gahunklefopper has only gotten smaller in your time since his classes.");
                        Console.WriteLine("'So, you're here for a fight, eh little twig? Well, let's do it now! You interrupted my midday nap, and I'm positively ticked off! Get them hands up!' The old man drops his cane and assumes a basic fighting stance. You're confident in your skills until his robe slips off, revealing an absolutely JACKED old man in full plate armor.");
                        Enemy gahunklefopper = new Enemy("Gahunklefopper", 15, 0, new Stats(3, 0, 0, 1), 20, Item.potion3);
                        Battle libraryFight = new Battle(new List<Enemy> { gahunklefopper }, 3);
                        libraryFight.Resolve(new List<Player> { player });
                    }
                    else
                    {
                        Console.WriteLine("In order to prepare, you head to the student store, Gatorgankers.");
                        gatorgankers.Resolve(new List<Player> { player });
                        Console.WriteLine("With your shopping done, you make your way to the library entrance. Get ready for a fight!");
                        Console.WriteLine("As you aproach the library, a guard stops you. 'ID, please?'");
                        Console.WriteLine("You flash your former student ID card, and the guard pales. 'Here to fight old Gahunklefopper, eh? Gotta say, I don't envy you.'");
                        Console.WriteLine("The guard gestures to a seat, and you sit down and wat. Then you wait some more. Your nerves give way to abject boredom. Everntually, a whole *hour* later, a hunched old man with a cane totters his way towrds you. Gahunklefopper has only gotten smaller in your time since his classes.");
                        Console.WriteLine("'So, you're here for a fight, eh little twig? Well, let's do it now! You interrupted my midday nap, and I'm positively ticked off! Get them hands up!' The old man drops his cane and assumes a basic fighting stance. You're confident in your skills until his robe slips off, revealing an absolutely JACKED old man in full plate armor.");
                        Enemy gahunklefopper = new Enemy("Gahunklefopper", 10, 0, new Stats(3, 0, 0, 1), 20, Item.potion3);
                        Battle libraryFight = new Battle(new List<Enemy> { gahunklefopper }, 10);
                        libraryFight.Resolve(new List<Player> { player });
                    }
                    Console.WriteLine("The hall is a smouldering mess after your duel with Gahunklefopper. He lies on the floor unconcious. You could take his armor.... it's far from mediocre, but it could protect you on the way to the barrier. It's not exctly *moral*, but hey, that's life.");
                    Console.WriteLine("1: LEAVE ARMOR | 2: TAKE ARMOR");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("You decide to be a good little two-shoes and leave the decript old man with a shred of decency");
                    }
                    if (input == "2")
                    {
                        Console.WriteLine("Yeah, morals are for schmucks, eh? I'm with you on that. You rip the plate armor off the unconcious man, feeling not even a shred of guilt.");
                        Player.inventory.Add(Item.gahunklefopperArmor);
                        gahunklefoppersWrath = true;
                    }
                    Console.WriteLine("The security guard comes out from thier hiding place behind a trashbin. 'So, uh... you won, huh? That hasn't happened in a WHILE. Well, you've got access to the library, and are free to take what you need provided you return it.'");
                    Console.WriteLine("(You won't be retutning it.)");
                    Console.WriteLine("The guard unlocks the door, and you walk in. After a bit of searching, you come across the magical artefacts section. All of the evil and good artefacts seem to be completely rented out. The Bowl of Infinite Ramen alone seems to have a backlog of several years of people putting it on hold. Thankfully, thre seems to be one left. The Towel of Dampening! It's... better than nothing. It's perfectly stupid! You stop buy the library registar, check out the slightly soggy towel, and with your collection assembeld, head out to the barrier. Do you stop by the student store first?");
                    Console.WriteLine("1: YES | 2: NO");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        gatorgankers.Resolve(new List<Player> { player });
                    }
                    else if (input == "2")
                    {
                        Console.WriteLine("Alrighty then.");
                    }
                    Console.WriteLine("With your buisness done, you set out to the Great Barrier.");
                }
                Console.WriteLine("The Great Barrier has loomed over your life for as long as you can remember. it looks almost like a soap bubble overhead.");
                Console.WriteLine("It's time to pop it.");
                Console.WriteLine("As you approach the barrier, you're stopped by two border guards!!");
                if (gundalfWrath == true && gahunklefoppersWrath == true)
                {
                    Console.WriteLine("Not only that, but you're also approached by both Gundalf AND Gahunklefopper! Beaten and bruised, they step up behind the guards with vengance in thier eyes.");
                    Battle finalFight1 = new Battle(new List<Enemy> {borderGuard1, borderGuard2, angryGundalf, angryHopper}, 0);
                    finalFight1.Resolve(new List<Player> { player });
                    Console.WriteLine("You... you did it! Gathering your items and stepping over the groaning border guards, you head towards the barrier. As the items get close to the barrier, they tingle with arcane energy. When they touch the barrier, a small hole opens in it. You step through, battered, bruised, but free.");
                    Console.WriteLine("YOU WIN!");Environment.Exit(0);
                }
                if (gundalfWrath == true && gahunklefoppersWrath == false)
                {
                    Console.WriteLine("Not only that, but you're also approached by Gundalf! Beaten and bruised, he steps up behind the guards with vengance in his eyes.");
                    Battle finalFight1 = new Battle(new List<Enemy> { borderGuard1, borderGuard2, angryGundalf}, 0);
                    finalFight1.Resolve(new List<Player> { player });
                    Console.WriteLine("You... you did it! Gathering your items and stepping over the groaning border guards, you head towards the barrier. As the items get close to the barrier, they tingle with arcane energy. When they touch the barrier, a small hole opens in it. You step through, battered, bruised, but free.");
                    Console.WriteLine("YOU WIN!"); Environment.Exit(0);
                }
                if (gundalfWrath == false && gahunklefoppersWrath == false)
                {
                    Battle finalFight1 = new Battle(new List<Enemy> { borderGuard1, borderGuard2}, 0);
                    finalFight1.Resolve(new List<Player> { player });
                    Console.WriteLine("You... you did it! Gathering your items and stepping over the groaning border guards, you head towards the barrier. As the items get close to the barrier, they tingle with arcane energy. When they touch the barrier, a small hole opens in it. You step through, battered, bruised, but free.");
                    Console.WriteLine("YOU WIN!"); Environment.Exit(0);
                }
                if (gundalfWrath == false && gahunklefoppersWrath == true)
                {
                    Console.WriteLine("Not only that, but you're also approached by Gahunklefopper! Beaten and bruised, he steps up behind the guards with vengance in his eyes.");
                    Battle finalFight1 = new Battle(new List<Enemy> { borderGuard1, borderGuard2, angryHopper }, 0);
                    finalFight1.Resolve(new List<Player> { player });
                    Console.WriteLine("You... you did it! Gathering your items and stepping over the groaning border guards, you head towards the barrier. As the items get close to the barrier, they tingle with arcane energy. When they touch the barrier, a small hole opens in it. You step through, battered, bruised, but free.");
                    Console.WriteLine("YOU WIN!"); Environment.Exit(0);
                }




            }
        }
    }
}


