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


    public class Monster : Character
    {
        //Fields
        


        //PROPS
        public MonsterEnums MonsterName { get; set; }
        public string Class { get; set; }



        //ctors


        public Monster(string name, int life, int maxLife, int ac, int str, int dex, int con, int wis, int intel, MonsterEnums monsterName)
            : base(name, life, maxLife, ac, str, dex, con, wis, intel)
        {
           


        }//unique props

        public Monster()
        {

        }

        //METHODS

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Name: {MonsterName}";
        }

        public override int CalcDamage()
        {
            return base.CalcDamage();
        }


    }//end public class
}//end namespace
