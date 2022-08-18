using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponLibrary.ClassWeaponInfo.WarriorWeapons
{
    [Serializable()]
    public class Maelstrom : Weapon
    {
        public Maelstrom()
        {
            MaxDamage = 6;
            MinDamage = 3;
            Name = @"Maelstrom";
            BonusHitChance = 2;
            WeapID = 27;
            savedWeap = "w3";
        }//end public
    }//end public class
}//end namespace
