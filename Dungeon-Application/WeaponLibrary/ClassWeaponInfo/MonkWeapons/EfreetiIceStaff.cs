using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.MonkWeapons
{
    [Serializable()]
    public class EfreetiIceStaff : Weapon
    {
        public EfreetiIceStaff
()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"EfreetiIceStaff";
            BonusHitChance = 2;
            WeapID = 12;
            savedWeap = "m3";
        }//end public
    }//end public class
}//end namespace
