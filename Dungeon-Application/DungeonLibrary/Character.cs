using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Character
    {
        //FIELDS
        private int _maxLife;
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        

        //PROPS

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }//MaxLife
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }//end Life
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }//end HitChance

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//Block

        

        //CONSTRUCTORS

        public Character(int life, string name, int hitChance, int block, int maxLife)
        {
            MaxLife = maxLife;
            Life = life;
            Name = name;
            HitChance = hitChance;
            Block = block;
            

        }//end Character

        public Character()
        {

        }//end default character ()

        //METHODS

        public override string ToString()
        {
            return $"{Name}\t\t {Life}\n" +
                   $"{HitChance}\n" +
                   $"{Block}\n";
                   
        }//end Character method

       

        

    }//end class Character
}//end Dungeon
