using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WarriorWeapons
{
    [Serializable()]
    public class RodOfDiscord : Weapon
    {
        public RodOfDiscord()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"Rod Of Discord";
            BonusHitChance = 2;
            WeapID = 26;
            savedWeap = "w2";
        }//end public
    }//end public class
}//end namespace
