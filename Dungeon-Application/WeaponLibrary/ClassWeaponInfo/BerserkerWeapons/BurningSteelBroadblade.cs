using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace WeaponLibrary.ClassWeaponInfo.BerserkerWeapons
{
    [Serializable()]
    public class BurningSteelBroadblade : Weapon
    {

        public BurningSteelBroadblade()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"BurningSteelBroadblade";
            BonusHitChance = 2;
            WeapID = 3;
            savedWeap = "b4";
        }
            
            
    }//end class
}//end namespace
