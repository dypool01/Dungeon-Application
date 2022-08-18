using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WarriorWeapons
{
    [Serializable()]
    public class BladeOfCarnage : Weapon
    {
        public BladeOfCarnage()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"Blade Of Carnage";
            BonusHitChance = 3;
            WeapID = 28;
            savedWeap = "w4";
        }//end public
    }//end public class
}//end namespace

