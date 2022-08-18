using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ClericWeapons
{
    [Serializable()]
    public class Fatespinner : Weapon
    {
        public Fatespinner()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"Fatespinner";
            BonusHitChance = 2;
            WeapID = 7;
            savedWeap = "c3";
        }//end public
    }//end public class
}//end namespace
