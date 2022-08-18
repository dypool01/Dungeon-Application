using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.MonkWeapons
{
    [Serializable()]
    public class WornGreatStaff : Weapon
    {
        public WornGreatStaff
()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"Worn GreatStaff";
            BonusHitChance = 2;
            WeapID = 10;
            savedWeap = "m1";
        }//end public
    }//end public class
}//end namespace