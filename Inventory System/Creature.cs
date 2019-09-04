using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Creature
    {
        public void Print()
        {
            
        }
        public void Fight(Creature enemy)
        {

        }
        protected int _health = 100;
        protected int _maxHealth = 100;
        public virtual void fight(Creature target)
        {
            int damage = GetDamage();
            _health -= damage;
            Console.WriteLine(GetName() + "attacks! " + target.GetName() + " takes " + damage);
        }
        public virtual void fight(Creature[] targets)
        {
            if (_health <= 0)
            {
                return;
            }

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
                if (choice >= 0 && choice < targets.Length)
                {
                    validInput = true;
                    fight(targets[choice]);
                }
            }
        }
        public virtual int GetDamage()
        {
            return 0;
        }
        public virtual string GetName()
        {
            return "";
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
    }
}
