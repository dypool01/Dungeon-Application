using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.BerserkerWeapons
{
    [Serializable()]
    public class DarkCrystalBlade : Weapon
    {

        public DarkCrystalBlade()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"DarkCrystalBlade";
            BonusHitChance = 2;
            WeapID = 2;
            savedWeap = "b3";
        }//end DarkCrystalBlade


    }//end class
}//end namespace
