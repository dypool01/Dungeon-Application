using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ShadowKnightWeapons
{
    [Serializable()]
    public class CarelessSigh : Weapon
    {
        public CarelessSigh()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"CarelessSigh";
            BonusHitChance = 3;
            WeapID = 24;
            savedWeap = "s5";
        }//end public
    }//end public class
}//end namespace
