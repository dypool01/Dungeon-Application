using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WizardWeapons
{
    [Serializable()]
    public class StaffOfNull : Weapon
    {
        public StaffOfNull()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"Staff Of Null";
            BonusHitChance = 4;
            WeapID = 34;
            savedWeap = "wi5";
        }//end public
    }//end public class
}//end namespace
