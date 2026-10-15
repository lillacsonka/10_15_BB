using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Character
    {
        private string _name;
        private int _health;
        private static int count;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                if (value > 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }

            }
        }
        public static int Count
        {
            get { return count; }
        }
        public Character(string name)
        {
            _name = name;
            count++;
            Health = 100;
        }
        public bool IsAlive()
        {
            if(_health > 0)
            {

                return true;
            }
            return false;
        }
        public virtual bool TakeDamage(int amount)
        {
            if(!IsAlive() || amount < 1)
            {
                return false;
            }
            Health = Health-amount;
            return true;
            
        }
        public bool Heal(int amount)
        {
            if (!IsAlive() || amount < 1)
            {
                return false;
            }
            Health += Health ;
            return true;

        }
        public virtual string GetDiscription()
        {
            return $"{Name},{Health}";
        }

        public bool Attack( Character target )
        {
            if(target.IsAlive() && IsAlive() )
            {
                target.TakeDamage(AttackPower());
                return true;
            }
            return false;
        }
        public abstract int AttackPower()
        {
            if(Mana >= 10)
            {
                Mana -= 10;
                return 25;
            }
            return base.AttackPower();
        }


    
    }
}