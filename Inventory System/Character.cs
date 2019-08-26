﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Character
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 };

        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }

        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " + _level);
            Console.WriteLine("Experience: " + _xp);
        }

        public int Experience
        {
            get
            {
                return _xp;
            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)
                {
                    if (_xp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + "'s level increased to " + _level + "!");
                    }
                }
            }
        }
    }
}
