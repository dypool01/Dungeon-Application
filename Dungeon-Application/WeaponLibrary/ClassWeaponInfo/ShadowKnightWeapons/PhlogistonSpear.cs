using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.ShadowKnightWeapons
{
    [Serializable()]
    public class PhlogistonSpear : Weapon
    {
        public PhlogistonSpear()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"Phlogiston Spear";
            BonusHitChance = 2;
            WeapID = 22;
            savedWeap = "s3";
        }//end public
    }//end public class
}//end namespace
