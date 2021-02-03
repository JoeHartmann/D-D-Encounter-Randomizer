using System;
using System.Collections.Generic;
namespace EncounterRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Roll Initiative!");
            Console.ReadKey();
            Console.Clear();

            var random = new Random();
            var monsters = new List<string> { "Bat\nPHB Pg.304", "Black Bear\nPHB Pg.304", "Boar\nPHB Pg.304", "Brown Bear\nPHB Pg.304", "Cat\nPHB Pg.305", "Constrictor Snake\nPHB Pg.305", "Crocodile\nPHB Pg.305", "Dire Wolf\nPHB Pg.305", "Frog\nPHB Pg.305",
            "Giant Eagle\nPHB Pg.306", "Giant Spider\nPHB Pg.306", "Hawk(Falcon)\nPHB Pg.306", "Imp\nPHB Pg.306", "Lion\nPHB Pg.307", "Mastiff\nPHB Pg.307", "Mule\nPHB Pg.307", "Owl\nPHB Pg.308", "Panther\nPHB Pg.308", "Poisonous Snake\nPHB Pg.308", "Psuedodragon\nPHB Pg.308",
            "Quasit\nPHB Pg.309", "Rat\nPHB Pg.309", "Raven\nPHB Pg.309", "Reef Shark\nPHB Pg.309", "Riding Horse\nPHB Pg.310", "Skeleton\nPHB Pg.310", "Sprite\nPHB Pg.310", "Tiger\nPHB Pg.310", "Tiger\nPHB Pg.311", "Warhorse\nPHB Pg.311", "Wolf\nPHB Pg.311", "Zombie\nPHB Pg.311"};
            int index = random.Next(monsters.Count);
            Console.WriteLine(monsters[index]);
            var amount = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int howMany = random.Next(amount.Count);
            Console.WriteLine("They will be facing " + amount[howMany]);
            Console.ReadKey();
            
        }
        static Random rnd = new Random();
    }
}
