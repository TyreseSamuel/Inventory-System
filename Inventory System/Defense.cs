using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class DefenseItem
    {
        private int _defense;
        public int Damage
        {
            get
            {
                return _defense;
            }
        }
        public DefenseItem(string newName, int newDefense, int newWeight)
        {
            //name = newName;
            _defense = newDefense;
            //weight = newWeight;
        }
    }
}
