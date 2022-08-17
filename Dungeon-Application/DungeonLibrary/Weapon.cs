using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Weapon
    {
        //FIELDS
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //PROPS
       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }//end HitChance

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//Block

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//MaxLife

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//end IsTwoHanded

        //CONSTRUCTORS

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;

        }//end Weapon Constructor

       

        //METHODS



    }//end class
}//end namespace
