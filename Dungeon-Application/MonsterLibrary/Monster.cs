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
        public int MaxDamage { get; set; }

        private int _minDamage;
        private int _bonusHitChance;
        public string Description { get; set; }
        public int MinDamage

        {
            get { return _minDamage; }
            //can't be more than maxdamage, can't be less than 1
            set
            {
                if (value > MaxDamage)
                {
                    _minDamage = 1;
                }//end if
                 //  else if (value < 1);
                 //  {
                 //      _minDamage = 1;
                 //  }
                else
                {
                    _minDamage = value;
                }
                // _minDamage = value > MaxDamage || value < 1 ? 1 : value;
            }//end else
        }//end MinDamage

        public int BonusHitChance { get; set; }

        //PROPS





        //ctors


        public Monster(string name, int life, int maxLife, int ac, int str, int dex, int con, int wis, int intel, string description, int maxDamage, int minDamage, int bonusHitChance)
            : base(name, life, maxLife, ac, str, dex, con, wis, intel)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            BonusHitChance = bonusHitChance;

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
            return new Random().Next(Str);// + 1 because it's exclusive
        }//end CalcDamage()

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + BonusHitChance; // needed to add the bonus hit chance to the hit chance added from strength to make it so the monster could hit.
            // Monster hits pretty much relying on BonusHitChance, may as well call it hit chance and rework strength.
        }

        public override int CalcBlock()
        {
            return base.CalcBlock();
        }
        //Monster Generator

        public static Monster GetMonster()
        {
            Monster skeleton = new Monster("Skeleton", 10, 10, 14, 15, 15, 15, 14, 14, "A set of reanimated bones. Doesn't look entirely human.", 5, 3, 15);
            Monster gnoll = new Monster("Gnoll", 12, 15, 15, 15, 14, 14, 14, 14, "A humanoid hyena that loves to burrow through the ground.", 7, 5, 17);
            Monster orc = new Monster("Orc", 20, 25, 17, 19, 16, 14, 14, 14, "Ugly humanoids with a penchant for war.", 20, 10, 20);
            Monster spider = new Monster("A Large Spider", 15, 15, 14, 17, 18, 14, 14, 14, "A rather large species of Tarantula that feeds opportunistically.", 12, 3, 25);

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
