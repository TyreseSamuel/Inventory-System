using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            _health = 150;
            _mana = 100;
            _strength = 3;
            _dexterity = 7;
            _wisdom = 10;
        }
    }
}
