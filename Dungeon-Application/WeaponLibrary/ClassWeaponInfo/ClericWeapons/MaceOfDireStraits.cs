using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ClericWeapons
{
    [Serializable()]
    public class MaceOfDireStraits : Weapon
    {
        public MaceOfDireStraits
()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"Mace Of Dire Straits";
            BonusHitChance = 2;
            WeapID = 8;
            savedWeap = "c4";
        }//end public
    }//end public class
}//end namespace
