using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.PaladinWeapons
{
    [Serializable()]
    public class Rocksmasher : Weapon
    {
        public Rocksmasher
()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"Rocksmasher";
            BonusHitChance = 2;
            WeapID = 16;
            savedWeap = "p2";
        }//end public
    }//end public class
}//end namespace

