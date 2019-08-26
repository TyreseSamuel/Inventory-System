using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class DefenseItem : Item
    {
        private int _defense;
        public int Damage
        {
            get
            {
                return _defense;
            }
        }
        public Defense_Item(string newName, int newDefense, int newWeight)
        {
            name = newName;
            _defense = newDefense;
            weight = newWeight;
        }
    }
}
