using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.PaladinWeapons
{
    [Serializable()]
    public class GhoulsBane : Weapon
    {
        public GhoulsBane()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"GhoulsBane";
            BonusHitChance = 2;
            WeapID = 18;
            savedWeap = "p4";
        }//end public
    }//end public class
}//end namespace
