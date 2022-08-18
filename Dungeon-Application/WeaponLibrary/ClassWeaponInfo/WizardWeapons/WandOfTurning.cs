using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WizardWeapons
{
    [Serializable()]
    public class WandOfTurning : Weapon
    {
        public WandOfTurning()
        {
            MaxDamage = 5;
            MinDamage = 3;
            Name = @"Wand of Turning";
            BonusHitChance = 2;
            WeapID = 31;
            savedWeap = "wi2";
        }//end public
    }//end public class
}//end namespace
