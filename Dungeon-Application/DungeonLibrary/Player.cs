﻿using System;
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
        public Weapon Weapon { get; set; }
        public string Class { get; set; }



        //ctors

        
        public Player( string name, int life, int maxLife, int ac, int str, int dex, int con, int wis, int intel, ClassesEnum playerjob, Races playerRace)
            : base(name, life, maxLife, ac, str, dex, con, wis, intel)
            {

            
            
            }//unique props

        public Player()
        {

        }

        //METHODS

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Class: {PlayerJob}\t\tRace: {PlayerRace}";
        }



    }//end public class
}//end namespace