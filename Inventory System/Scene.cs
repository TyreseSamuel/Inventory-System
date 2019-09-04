using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;

        public Scene(string name, int northID, int southID, int eastID, int westID, string description)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = "Nothing was found";
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public int ChooseExit()
        {
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {
                Console.WriteLine("Where to my guy? ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            }
            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else
            {
                return -1;
            }
        }
    }
}
