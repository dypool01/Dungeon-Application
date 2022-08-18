using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.MonkWeapons
{
    [Serializable()]
    public class FistsOfFate : Weapon
    {
        public FistsOfFate
()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"Fists Of Fate";
            BonusHitChance = 3;
            WeapID = 14;
            savedWeap = "m5";
        }//end public
    }//end public class
}//end namespace
