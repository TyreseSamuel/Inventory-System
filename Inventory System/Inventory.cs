using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        int damage = 0;
        int potion = 25;
        float gold = 0.00f;
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip weapon");
                Console.WriteLine("2: Unequip weapon");
                Console.WriteLine("3: Add gold");
                Console.WriteLine("4: Subtract gold");
                choice = Console.ReadLine();
                if(choice == "1")
                {
                    EquipWeapon();
                    
                }
                else if(choice == "2")
                {
                    UnEquipWeapon();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold?");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("How much gold?");
                    float subtractedGold = Convert.ToSingle(Console.ReadLine());
                    SubtractGold(subtractedGold);
                }
            }
        }
        public void EquipWeapon()
        {
            string choice = "";
            while (choice != "Cancel")
            {
                Console.WriteLine("\nBow");
                Console.WriteLine("Sword");
                Console.WriteLine("Hammer");
                Console.WriteLine("Battleaxe");
                Console.WriteLine("Cancel\n");

                choice = Console.ReadLine();
                if (choice == "Bow")
                {
                    damage = 15;
                }
                else if (choice == "Sword")
                {
                    damage = 20;
                }
                else if (choice == "Hammer")
                {
                    damage = 30;
                }
                else if (choice == "Battleaxe")
                {
                    damage = 40;
                }

                Console.WriteLine("Equipped a " + choice + "!");
                Console.WriteLine("Damage: " + damage);
            }
        }
        public void UnEquipWeapon()
        {
            Console.WriteLine("Unequipped a weapon!");
            damage = 10;
            Console.WriteLine("Damage: " + damage);

        }
        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("Damage: " + damage);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            gold -= amount;
            Console.WriteLine("Damage: " + damage);
        }

        public void BuyPotion(float amount)
        {
            Console.WriteLine("Want an overall boost potion?");
            gold -= amount;

        }
    }
}
