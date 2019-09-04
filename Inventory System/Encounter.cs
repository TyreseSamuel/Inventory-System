using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Encounter
    {
        private Creature[] _goodMonsters;
        private Creature[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }

        public void Print()
        {
            //goodMonsters
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            //badMonsters
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Creature currentMonster = _goodMonsters[i];
                currentMonster.Fight(_badMonsters[0]);
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                Creature currentMonster = _badMonsters[1];
                currentMonster.Fight(_goodMonsters[0]);
            }
        }

        public void Start()
        {
            Console.WriteLine("\nLet's Begin!!!");
            bool stillFighting = true;
            while (stillFighting)
            {
                bool goodIsAlive = true;
                for (int i = 0; i < _goodMonsters.Length; i++)
                {
                    Creature currentMonster = _goodMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        goodIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        goodIsAlive = false;
                    }
                }
                bool badIsAlive = true;
                for (int i = 0; i < _badMonsters.Length; i++)
                {
                    Creature currentMonster = _badMonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        badIsAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        badIsAlive = false;
                    }
                }

                if (goodIsAlive && badIsAlive)
                {
                    stillFighting = true;
                    BeginRound();
                }
                else
                {
                    stillFighting = false;
                }
                Print();
            }
        }
    }
}
