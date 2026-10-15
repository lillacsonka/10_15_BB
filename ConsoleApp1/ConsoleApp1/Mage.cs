using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mage: Character
    {
        private int _mana;
        public int Mana
        {
            get { return _mana; }
            set { 
                    if (Mana < 0){ Mana = 0; } 
                    else { Mana = value; }
                } 
        }

        public Mage(string name, int mana): base(name)
        {
            Mana = mana;
        }
        public override string GetDiscription()
        {
            return base.GetDiscription() + "- Mana: " + Mana;
        }
    }
}
