using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Berserker : Character
    {
        public Berserker(string name) : base(name)
        {
            _health = 250;
            _mana = 10;
            _strength = 10;
            _dexterity = 3;
            _wisdom = 4;
        }
    }
}
