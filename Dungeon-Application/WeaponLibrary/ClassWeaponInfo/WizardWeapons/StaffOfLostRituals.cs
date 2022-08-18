using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WizardWeapons
{
    [Serializable()]
    public class StaffofLostRituals : Weapon
    {
        public StaffofLostRituals()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"Staff Of Lost Rituals";
            BonusHitChance = 2;
            WeapID = 32;
            savedWeap = "wi3";
        }//end public
    }//end public class
}//end namespace
