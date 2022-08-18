using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ShadowKnightWeapons
{
    [Serializable()]
    public class DreadSpine : Weapon
    {
        public DreadSpine()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"DreadSpine";
            BonusHitChance = 2;
            WeapID = 23;
            savedWeap = "s4";
        }//end public
    }//end public class
}//end namespace
