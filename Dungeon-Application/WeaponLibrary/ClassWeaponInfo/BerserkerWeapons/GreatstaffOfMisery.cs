using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.BerserkerWeapons
{
    [Serializable()]
    public class GreatstaffOfMisery : Weapon
    {
        public GreatstaffOfMisery()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"GreatstaffOfMisery";
            BonusHitChance = 2;
            WeapID = 1;
            savedWeap = "b2";
        }

    }//end class
}//end namespace
