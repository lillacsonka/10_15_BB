using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Warrior : Character
    {
        private int _armor;
        public int Armor { get { return _armor; } set { if (value > 0) { Armor = value; } else { value = 0; } } }
        public Warrior(string name, int armor): base(name)
        {
            Armor = armor;
        }

        public override string GetDiscription()
        {
            return base.GetDiscription() + "- Armour: " + Armor;
        }
    }
}
