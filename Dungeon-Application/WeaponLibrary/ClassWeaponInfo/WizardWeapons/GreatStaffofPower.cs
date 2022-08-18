using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WizardWeapons
{
    [Serializable()]
    public class GreatStaffofPower : Weapon
    {
        public GreatStaffofPower()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"GreatStaffofPower";
            BonusHitChance = 2;
            WeapID = 33;
            savedWeap = "wi4";
        }//end public
    }//end public class
}//end namespace
