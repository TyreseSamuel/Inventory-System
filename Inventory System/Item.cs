﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Attack_Item
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        public Attack_Item(string newName, int newDamage, int newWeight)
        {
            //Name = newName;
            _damage = newDamage;
            //weight = newWeight;
        }
    }
}
