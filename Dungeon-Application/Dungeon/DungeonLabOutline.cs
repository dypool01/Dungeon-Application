using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DungeonLibrary;
using DungeonLibrary.Enums;

namespace Dungeon
{
    internal class DungeonLabOutline
    {
        static void Main(string[] args)
        {
            

            bool end = true;

            ConsoleKeyInfo keyInfo; 

            do
            {
                #region Intro

                //TODO Create exit in intro add ifs and else
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NEVERQUEST");
            Console.Title = "NEVERQUEST";
            Console.WriteLine();
            Console.WriteLine("Press A to continue.\n" + 
                "Or press E to exit.");
            Console.WriteLine();
                string cont = Console.ReadKey(true).Key.ToString();

                 switch (cont)
                 {
                    case "A":
                        
                        break;
                   case "E":
                         end = false;
                        break;
                 }//end switch
                

            Console.Clear();

            
            #endregion

            //TODO create exit for inner loop.

            //TODO redo player creation after making races and classes as race and class will influence player stats
            
            #region Player Creation
            Console.WriteLine("Please name your character.");
            Console.WriteLine();
                Player main = new Player();
            //     This is where the player is being defined.
                //  To modify any stats you will have to access them via main.Whatever is being modified.
            main.Name = Console.ReadLine();
            Console.Clear();
                #region Character Race Selection

               
                Console.WriteLine("Choose your characters race.");
                Console.WriteLine("\n" +
                        "1. Elf\n" +
                        "2. Human\n" +
                        "3. Erudite\n" +
                        "4. Iksar\n" +
                        "5. Troll\n" +
                        "6. Ogre");
                switch (Console.ReadLine())
                {
                    case "1":
                        
                            Console.WriteLine("You've chosen Elf");
                            main.PlayerRace = Races.Elf;
                            main.MaxLife = 80;
                            main.Life = main.MaxLife;
                            main.Str = 15;
                            main.Dex = 18;
                            main.Con = 15;
                            main.Intel = 20;
                            main.Wis = 18;
                        break;

                    case "2":

                        Console.WriteLine("You've chosen Human");
                        main.PlayerRace = Races.Human;
                        main.MaxLife = 100;
                        main.Life = main.MaxLife;
                        main.Str = 17;
                        main.Dex = 17;
                        main.Con = 17;
                        main.Intel = 17;
                        main.Wis = 17;
                        break;

                    case "3":

                        Console.WriteLine("You've chosen Erudite");
                        main.PlayerRace = Races.Erudite;
                        main.MaxLife = 95;
                        main.Life = main.MaxLife;
                        main.Str = 17;
                        main.Dex = 17;
                        main.Con = 16;
                        main.Intel = 19;
                        main.Wis = 18;
                        break;

                    case "4":

                        Console.WriteLine("You've chosen Iksar");
                        main.PlayerRace = Races.Iksar;
                        main.MaxLife = 115;
                        main.Life = main.MaxLife;
                        main.Str = 18;
                        main.Dex = 20;
                        main.Con = 16;
                        main.Intel = 17;
                        main.Wis = 19;
                        break;

                    case "5":

                        Console.WriteLine("You've chosen Troll");
                        main.PlayerRace = Races.Troll;
                        main.MaxLife = 125;
                        main.Life = main.MaxLife;
                        main.Str = 19;
                        main.Dex = 17;
                        main.Con = 18;
                        main.Intel = 16;
                        main.Wis = 17;
                        break;

                    case "6":

                        Console.WriteLine("You've chosen Ogre");
                        main.PlayerRace = Races.Ogre;
                        main.MaxLife = 150;
                        main.Life = main.MaxLife;
                        main.Str = 20;
                        main.Dex = 15;
                        main.Con = 16;
                        main.Intel = 17;
                        main.Wis = 19;
                        break;

                    default : Console.WriteLine("You have not chosen a playable race.");
                        break;
                }//end switch
                #endregion
                Console.Clear();
                Console.WriteLine("Choose your characters job.");
                Console.WriteLine("\n" +
                        "1. Berserker\n" +
                        "2. Cleric\n" +
                        "3. Monk\n" +
                        "4. Paladin\n" +
                        "5. ShadowKnight\n" +
                        "6. Warrior\n" +
                        "7. Wizard");

                switch (Console.ReadLine())
                {
                    case "1":
                        main.PlayerJob = ClassesEnum.Berserker;
                        main.AC = 17;
                   //    main.Str += 5;
                   //    main.Dex += 3;
                   //    main.Con += 2;
                   //    main.Intel += 3;
                   //    main.Wis += 14;
                        break;

                    case "2":
                        main.PlayerJob = ClassesEnum.Cleric;
                        main.AC = 21;
                  //      main.Str = 17;
                  //      main.Dex = 18;
                  //      main.Con = 18;
                  //      main.Intel = 17;
                  //      main.Wis = 20;
                        break;

                    case "3":
                        main.PlayerJob = ClassesEnum.Monk;
                        main.AC = 15;
                  //      main.Str = 19;
                  //      main.Dex = 20;
                  //      main.Con = 18;
                  //      main.Intel = 17;
                  //      main.Wis = 17;
                        break;

                    case "4":
                        main.PlayerJob = ClassesEnum.Paladin;
                        main.AC = 23;
                   //     main.Str = 18;
                   //     main.Dex = 18;
                   //     main.Con = 19;
                   //     main.Intel = 16;
                   //     main.Wis = 17;
                        break;

                    case "5":
                        main.PlayerJob = ClassesEnum.ShadowKnight;
                        main.AC = 23;
                   //     main.Str = 18;
                   //     main.Dex = 18;
                   //     main.Con = 19;
                   //     main.Intel = 17;
                   //     main.Wis = 16;
                        break;

                    case "6":
                        main.PlayerJob = ClassesEnum.Warrior;
                        main.AC = 25;
                   //     main.Str = 19;
                   //     main.Dex = 19;
                   //     main.Con = 20;
                   //     main.Intel = 14;
                   //     main.Wis = 14;
                        break;

                    case "7":
                        main.PlayerJob = ClassesEnum.Wizard;
                        main.AC = 15;
                    //    main.Str = 15;
                    //    main.Dex = 16;
                    //    main.Con = 16;
                    //    main.Intel = 20;
                    //    main.Wis = 20;
                        break;

                    default : Console.WriteLine("You have not chosen a playable class");
                        break;
                }//end switch
                #endregion


                Console.WriteLine();
                
                bool exit = true;
                do
                {

                    Random rng = new Random();

                    int rand = rng.Next(6);

                    decimal randMon = rng.Next(5);

                    

                    //3. TODO Create a Room

                    decimal room = rand;

                    switch (room)
                    {
                        case 0:
                            //TODO create breakout of inner loop when winning or losing.
                            Console.WriteLine("You enter a dimly lit Foyer");
                            break;

                        case 1:
                            Console.WriteLine("You enter a dark bedroom ");
                            break;

                        case 2:
                            Console.WriteLine("You have stumbled into a cave ");
                            break;

                        case 3:
                            Console.WriteLine("You have blundered into the structures dungeon ");
                            break;

                        case 4:
                            Console.WriteLine("You approach a (insert monster) lair ");
                            break;

                        case 5:
                            Console.WriteLine("You discover the remains of a shop ");
                            break;

                        case 6:
                            Console.WriteLine("A wall crumbles revealing a hidden library ");
                            break;

                        default:
                            Console.WriteLine("You shouldn't be here!");
                            break;
                    }//end switch

                    // Fix The Monster Generator
                    //currently outputs a random integer

                    switch (randMon)
                    {
                        case 0:
                            Monster mon1 = new Monster("WereWolf", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.AWereWolf);
                            Console.WriteLine("You encounter a" + mon1.Name);
                            break;
                        case 1:
                            Monster mon2 = new Monster("Zombie", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.AZombie);
                            Console.WriteLine("You encounter a" + mon2.Name);
                            break;
                        case 2:
                            Monster mon3 = new Monster("Gnoll", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.AGnoll);
                            Console.WriteLine("You encounter a" + mon3.Name);
                            break;
                        case 3:
                            Monster mon4 = new Monster("Skeleton", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.ASkeleton);
                            Console.WriteLine("You encounter a" + mon4.Name);
                            break;
                        case 4:
                            Monster mon5 = new Monster("Frost Bite Spider", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.AFrostBiteSpider);
                            Console.WriteLine("You encounter a" + mon5.Name);
                            break;
                        case 5:
                            Monster mon6 = new Monster("Dragon", 100, 150, 10, 16, 14, 15, 14, 14, MonsterEnums.ADragon);
                            Console.WriteLine("You encounter a" + mon6.Name);
                            break;
                        default:
                            Console.WriteLine("nothing appears");
                            break;
                    }//end switch
                    bool win = true;


                    //1. TODO create menu
                    Console.WriteLine("\n" +
                        "A. Attack\n" +
                        "B. Run Away\n" +
                        "C. Character Info\n" +
                        "D. Monster Info\n" +
                        "E. Exit");


                    //2.TODO create switch

                    string choice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();

                    switch (choice)
                    {
                        case "A":
                            //TODO create breakout of inner loop when winning or losing.
                            Console.WriteLine("Attack");
                            win = true;
                            if (win)
                            {
                                Console.WriteLine("You have slain (insert monster here)");
                            }
                            else
                            {
                                Console.WriteLine("You have been slain by (Monster)");
                            }
                            break;

                        case "B":
                            Console.WriteLine("Run Away");
                            exit = false;
                            break;

                        case "C":
                            Console.WriteLine("Character Info");
                            Console.WriteLine(main);
                            exit = false;
                            break;

                        case "D":
                            Console.WriteLine("Monster Info");
                            exit = false;
                            break;

                        case "E":
                        case "Escape":
                            Console.WriteLine("You are now exiting ");
                            exit = true;
                            end = true;
                            break;

                        default:
                            Console.WriteLine("There are no cheat buttons");
                            break;
                    }//end switch

                    if (!exit)
                    {
                        Console.WriteLine("Press any key to start another random encounter...");
                        Console.ReadKey();
                        Console.Clear();
                    }//end if




                } while (exit == true); ; //end do while


                } while (end == true); //end do while

            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion
        }//end main()

    }//end class
}//end namespace
