using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Monster : Creature
    {
        private string _name = "Kneegrow";
        private int _health = 100;
        private int _maxHealth = 100;
        private int _damage = 25;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
        }
        public string GetName()
        {
            return _name;
        }

        public override int GetDamage()
        {
            return _damage;
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (_health < 0)
                {
                    _health = 0;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("\n" + _name);
            Console.WriteLine("Health: " + _health + "/" + _maxHealth);
            Console.WriteLine("Damage: " + _damage);            
            Console.ReadKey();

        }

        public void Fight(Monster target)
        {
            int damage = GetDamage();
            target.Health -= damage;
            Console.WriteLine(GetName() + "attacks! " + target.GetName() + " takes " + damage);
        }

        public void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            Random random = new Random();
            int choice = random.Next(0, targets.Length - 1);
            Fight(targets[choice]);

            /*
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nWho will " + GetName() + " fight? ");
                for (int i = 0; i < targets.Length; i++)
                {
                    string targetName = targets[i].GetName();
                    Console.WriteLine(i + ": " + targetName);
                }

                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);
                if(choice >= 0 && choice < targets.Length)
                {
                    validInput = true;
                    Fight(targets[choice]);
                }
            }
            */
        }
    }
}
