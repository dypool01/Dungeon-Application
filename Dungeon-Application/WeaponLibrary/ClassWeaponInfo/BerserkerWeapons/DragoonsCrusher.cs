using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.BerserkerWeapons
{
    [Serializable()]
    public class DragoonsCrusher : Weapon
    {
        public DragoonsCrusher()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"DragoonsCrusher";
            BonusHitChance = 3;
            WeapID = 4;
            savedWeap = "b5";
        }//end public
    }//end public class
}//end namespace
