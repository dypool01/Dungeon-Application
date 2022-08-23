using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary.Enums;


namespace DungeonLibrary
{
    [Serializable()]
    //make it public
    //make it a child

    
    public class Player : Character
    {
        //Fields
        //TODO make pages for speech, maximum exp, discount, spells, money, items.


        //PROPS
        public ClassesEnum PlayerJob { get; set; }
        public Races PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public string Class { get; set; }

        

        //ctors

        
        public Player( string name, int life, int maxLife, int ac, int str, int dex, int con, int wis, int intel, ClassesEnum playerjob, Races playerRace, Weapon equippedWeapon)
            : base(name, life, maxLife, ac, str, dex, con, wis, intel)
            {
            EquippedWeapon = equippedWeapon;
            
            
            }//unique props

        public Player()
        {

        }

        //METHODS

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Class: {PlayerJob}\t\tRace: {PlayerRace}\n" +
                $"Weapon: {EquippedWeapon}";

        }//end override string

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();//0, we don't want it!
            //Random Object
            Random rand = new Random();

            //Weapon has max and min damage.

            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;

            //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }



    }//end public class
}//end namespace
