using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.PaladinWeapons
{
    [Serializable()]
    public class Anathema : Weapon
    {
        public Anathema()
        {
            MaxDamage = 8;
            MinDamage = 6;
            Name = @"Anathema";
            BonusHitChance = 3;
            WeapID = 19;
            savedWeap = "p5";
        }//end public
    }//end public class
}//end namespace

