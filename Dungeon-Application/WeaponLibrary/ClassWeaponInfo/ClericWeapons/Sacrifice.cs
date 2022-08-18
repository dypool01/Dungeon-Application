using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ClericWeapons
{
    [Serializable()]
    public class Sacrifice : Weapon
    {
        public Sacrifice()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"Sacrifice";
            BonusHitChance = 2;
            WeapID = 6;
            savedWeap = "c2";
        }//end public
    }//end public class
}//end namespace
