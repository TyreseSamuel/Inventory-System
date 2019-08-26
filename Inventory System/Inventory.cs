using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        private int _itemDamage = 10;
        private int _itemDefense = 0;
        private int _weightFromWeapon = 0;
        private int _weightFromArmor = 0;
        private int _weightCapacity = 45;
        private float _gold = 0.00f;
        private int _potions = 0;
        private Attack_Item sword = new Attack_Item("Master Sword", 10, 3);
        private Attack_Item sword2 = new Attack_Item("Not Master Sword", 10, 3);
        private Attack_Item[] weapons = new Attack_Item[3];
        public Inventory()
        {
            Attack_Item[] weaponBag = { sword, sword2 };
            weapons = weaponBag;
        }

        //Returns the damage our weapons deals
        public int GetItemDamage()
        {
            return _itemDamage;
        }

        //Returns the defense our armor grants
        public int GetItemDefense()
        {
            return _itemDefense;
        }
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
                    _itemDamage = 15;
                }
                else if (choice == "Sword")
                {
                    _itemDamage = 20;
                }
                else if (choice == "Hammer")
                {
                    _itemDamage = 30;
                }
                else if (choice == "Battleaxe")
                {
                    _itemDamage = 40;
                }

                Console.WriteLine("Equipped a " + choice + "!");
                Console.WriteLine("Damage: " + _itemDamage);
            }
        }
        public void UnEquipWeapon()
        {
            Console.WriteLine("Unequipped a weapon!");
            _itemDamage = 10;
            Console.WriteLine("Damage: " + _itemDamage);

        }
        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Damage: " + _itemDamage);
        }
        public void SubtractGold(float amount)
        {
            Console.WriteLine("Lost " + amount + " gold!");
            _gold -= amount;
            Console.WriteLine("Damage: " + _itemDamage);
        }

        public void BuyPotion(float amount)
        {
            Console.WriteLine("Want an overall boost potion?");
            _gold -= amount;

        }
    }
}
