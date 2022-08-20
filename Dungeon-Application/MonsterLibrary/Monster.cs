using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace MonsterLibrary
{
    [Serializable()]
    //make it public
    //make it a child


    public class Monster : Character
    {
        //Fields




        //PROPS

        public string Description { get; set; }



        //ctors


        public Monster(string name, int life, int maxLife, int ac, int str, int dex, int con, int wis, int intel, string description)
            : base(name, life, maxLife, ac, str, dex, con, wis, intel)
        {
            Description = description;


        }//unique props

        public Monster()
        {

        }//end default CTOR

        //METHODS

        public override string ToString()
        {
            return $@"
********** MONSTER **********
{Name}
Life: {Life} of {MaxLife}
AC: {AC}    Con: {Con}
Str: {Str}  Dex: {Dex}


";
        }//end end Monster Stats string

        public override int CalcDamage()
        {
            return base.CalcDamage();
        }//this will give us the damage the monster deals

        //Monster Generator

        public static Monster GetMonster()
        {
            Monster skeleton = new Monster("Skeleton", 10, 10, 14, 15, 15, 15, 14, 14, "A set of reanimated bones. Doesn't look entirely human.");
            Monster gnoll = new Monster("Gnoll", 12, 15, 15, 16, 16, 14, 14, 14, "A humanoid hyena that loves to burrow through the ground.");
            Monster orc = new Monster("Orc", 20, 25, 17, 16, 16, 16, 14, 14, "Ugly humanoids with a penchant for war.");
            Monster spider = new Monster("A Large Spider", 15, 15, 14, 15, 18, 14, 14, 14, "A rather large species of Tarantula that feeds opportunisticly");

            Random rand = new Random();
            List<Monster> monsters = new List<Monster>()
            {
                skeleton, skeleton, skeleton, skeleton,
                gnoll, gnoll, gnoll, gnoll,
                orc, orc,
                spider, spider, spider
            };//end list

            return monsters[rand.Next(monsters.Count)];
        }//end GetMonster()


    }//end public class

}//end namespace
