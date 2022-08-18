using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace WeaponLibrary.ClassWeaponInfo.BerserkerWeapons
{
    [Serializable()]
    public class GreatbladeOfChaos : Weapon
    {

        public GreatbladeOfChaos()
        {
            MaxDamage = 8;
            MinDamage = 4;
            Name = @"GreatbladeOfChaos";
            BonusHitChance = 2;
            WeapID = 0;
            savedWeap = "b1";
        }
            

    }//end class
}//end namespace
