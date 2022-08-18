using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ClericWeapons
{
    [Serializable()]
    public class HammerOfHolyVengeance : Weapon
    {
        public HammerOfHolyVengeance
()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"Hammer Of Holy Vengeance";
            BonusHitChance = 3;
            WeapID = 9;
            savedWeap = "c5";
        }//end public
    }//end public class
}//end namespace