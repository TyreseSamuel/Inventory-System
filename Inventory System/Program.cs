using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //0: Courtyard
            //1: Castle Gate
            //2: Grave Yard
            //3: Village

            Scene courtyard = new Scene("Courtyard", 1, 3, -1, 2, "The courtyard is wide and open to the sky. There is a small garden nearby. There are exits to the north, south, and west.");
            Scene castleGate = new Scene("Castle Gate", -1, 0, -1, -1, "There is a massive gate at the entrance to the \ncastle. It appears to be locked. There is an exit to the south. ");
            Scene graveyard = new Scene("Graveyard", -1, -1, 0, -1, "The graveyard is pretty spooky. Nonetheless, you pay respects. There is an exit to the east. ");
            Scene village = new Scene("Village", 0, -1, -1, -1, "There is a village. There are a bunch of buildings, I guess. There is an exit to the west. ");

            Scene[] scenes = { courtyard, castleGate, graveyard, village };
            Map map = new Map(0, scenes);

            map.Menu();
            return;
            */

            Monster Vegeta = new Monster("Vegeta", 100, 50);
            Monster Buu = new Monster("Buu", 100, 50);
            Monster Cell = new Monster("Cell", 100, 50);
            Monster Omega = new Monster("Omega", 100, 50);

            Cell.Print();
            Buu.Print();

            Monster[] team1 = { Vegeta, Buu };
            Monster[] team2 = { Cell, Omega };

            Encounter encounter = new Encounter(team1, team2);
            encounter.Print();
            encounter.BeginRound();

            Console.ReadKey();
            return;

            //Inventory inventory = new Inventory();
            //inventory.Menu();
            string name = "";
            string choice = "";

            while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Whose Inventory: ");
                name = Console.ReadLine();
                //Display menu
                Console.WriteLine("\nChoose a job: ");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Wizard");
                Console.WriteLine("3: Rogue");
                Console.WriteLine("4: Berserker");
                choice = Console.ReadLine();
            }
            Character player;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Wizard(name);
            }
            else if (choice == "3")
            {
                player = new Rogue(name);
            }
            else if (choice == "4")
            {
                player = new Berserker(name);
            }
            else
            {
                player = new Character(name);
            }
            player.Print();

            player.OpenInventory();

            Rogue Hit = new Rogue("Hit");
            Hit.Print();
            Console.WriteLine("");

            Knight Goku = new Knight("Goku");
            Wizard Frieza = new Wizard("Frieza");
            Berserker Broly = new Berserker("Broly");
            Goku.Print();
            Console.WriteLine("");
            Frieza.Print();
            Console.WriteLine("");
            Broly.Print();
            Console.WriteLine("");

            while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("\nWhose Inventory? ");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + Goku.Name());
                Console.WriteLine("3: " + Frieza.Name());
                Console.WriteLine("4: " + Broly.Name());
            }


            player.Experience = 30;
            player.Experience = player.Experience + 50;
            player.Experience++;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;

            int[] testArray = new int[4];

            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };

            string[] stringArray = new string[3];

            Character[] party = { player, Goku, Frieza, Broly, new Character("Like") };

            Console.ReadKey();
        }
    }
}
