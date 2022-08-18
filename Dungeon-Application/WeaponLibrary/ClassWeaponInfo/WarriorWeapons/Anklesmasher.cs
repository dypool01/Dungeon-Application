using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WarriorWeapons
{
    [Serializable()]
    public class Anklesmasher : Weapon
    {
        public Anklesmasher()
        {
            MaxDamage = 3;
            MinDamage = 3;
            Name = @"Anklesmasher";
            BonusHitChance = 2;
            WeapID = 25;
            savedWeap = "w1";
        }//end public
    }//end public class
}//end namespace

