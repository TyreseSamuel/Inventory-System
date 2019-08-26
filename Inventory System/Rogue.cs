using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            _health = 200;
            _mana = 50;
            _strength = 5;
            _dexterity = 10;
            _wisdom = 5;
        }
    }
}
