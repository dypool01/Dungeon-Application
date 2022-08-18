using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.MonkWeapons
{
    [Serializable()]
    public class ShadowFlameStaff : Weapon
    {
        public ShadowFlameStaff
()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"ShadowFlameStaff";
            BonusHitChance = 2;
            WeapID = 11;
            savedWeap = "m2";
        }//end public
    }//end public class
}//end namespace
