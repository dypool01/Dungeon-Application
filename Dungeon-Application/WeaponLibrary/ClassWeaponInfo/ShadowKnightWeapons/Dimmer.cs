using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ShadowKnightWeapons
{
    [Serializable()]
    public class Dimmer : Weapon
    {
        public Dimmer()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"Dimmer";
            BonusHitChance = 2;
            WeapID = 21;
            savedWeap = "s2";
        }//end public
    }//end public class
}//end namespace
