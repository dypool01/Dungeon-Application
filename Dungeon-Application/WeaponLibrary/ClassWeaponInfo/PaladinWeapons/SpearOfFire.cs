using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.PaladinWeapons
{
    [Serializable()]
    public class SpearOfFire : Weapon
    {
        public SpearOfFire
()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"SpearOfFire";
            BonusHitChance = 2;
            WeapID = 17;
            savedWeap = "p3";
        }//end public
    }//end public class
}//end namespace

