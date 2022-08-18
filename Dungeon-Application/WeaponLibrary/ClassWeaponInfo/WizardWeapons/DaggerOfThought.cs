using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WizardWeapons
{
    [Serializable()]
    public class DaggerOfThought : Weapon
    {
        public DaggerOfThought()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"Dagger of Thought";
            BonusHitChance = 2;
            WeapID = 30;
            savedWeap = "wi1";
        }//end public
    }//end public class
}//end namespace
