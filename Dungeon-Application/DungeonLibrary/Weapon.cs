using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    [Serializable()]
    public class Weapon
    {
        private int _minDamage;//this is the minimum damage that a weapon can do
        private int _maxDamage;//this is the maximum damage that a weapon can do
        private string _name;//this is the name of the weapon
        private int _bonusHitChance;//this is the weapons chance to land a critical strike.
        private bool _isTwoHanded;
        private WeaponType _type;
        public int WeapID { get; set; }
        public string savedWeap { get; set; }
        

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//end TwoHanded bool

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//end MaxDam

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//end BonusHitChance



        //Business rule for mindamage.
        //Cannot be more then maxdamage
        //cannot be less then 0

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value < MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }

        }

        public Weapon()
        {

        }

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            //if you have any properties that have business rules that are based off any other
            //properties, set those properties first.
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;



        }//end constructor

        //Methods
        public override string ToString()
        {
            return string.Format("{0}\t{1}-{2} Damage + {3} Hit/Damage",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                Type,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }
    }//end Weapon
}//end namespace