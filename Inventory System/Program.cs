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
            //Inventory inventory = new Inventory();
            //inventory.Menu();

            Character player = new Character("Hit");
            player.Print();

            Character Goku = new Character("Goku");
            Character Frieza = new Character("Frieza");
            Goku.Print();
            Frieza.Print();

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

            Character[] party = { player, Goku, Frieza, new Character("Like") };

            Console.ReadKey();
        }
    }
}
