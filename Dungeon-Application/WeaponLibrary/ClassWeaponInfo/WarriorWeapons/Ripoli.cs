using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WarriorWeapons
{
    [Serializable()]
    public class Ripoli : Weapon
    {
        public Ripoli()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"Ripoli The Warriors Havoc";
            BonusHitChance = 4;
            WeapID = 29;
            savedWeap = "w5";
        }//end public
    }//end public class
}//end namespace
