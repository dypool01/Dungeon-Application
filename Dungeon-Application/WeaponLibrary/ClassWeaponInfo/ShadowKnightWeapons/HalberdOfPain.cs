using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ShadowKnightWeapons
{
    [Serializable()]
    public class HalberdOfPain : Weapon
    {
        public HalberdOfPain()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"HalberdOfPain";
            BonusHitChance = 2;
            WeapID = 20;
            savedWeap = "s1";
        }//end public
    }//end public class
}//end namespace
