using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.MonkWeapons
{
    [Serializable()]
    public class KatarOfResolve : Weapon
    {
        public KatarOfResolve
()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"KatarOfResolve";
            BonusHitChance = 2;
            WeapID = 13;
            savedWeap = "m4";
        }//end public
    }//end public class
}//end namespace
