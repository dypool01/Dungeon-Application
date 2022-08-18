using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.PaladinWeapons
{
    [Serializable()]
    public class Crusader : Weapon
    {
        public Crusader
()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"Crusader";
            BonusHitChance = 2;
            WeapID = 15;
            savedWeap = "p1";
        }//end public
    }//end public class
}//end namespace
