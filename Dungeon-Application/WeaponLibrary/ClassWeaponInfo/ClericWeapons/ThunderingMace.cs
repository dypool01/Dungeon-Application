using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ClericWeapons
{
    [Serializable()]
    public class ThunderingMace : Weapon
    {
        public ThunderingMace()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"Thundering Mace";
            BonusHitChance = 2;
            WeapID = 5;
            savedWeap = "c1";
        }//end public
    }//end public class
}//end namespace
