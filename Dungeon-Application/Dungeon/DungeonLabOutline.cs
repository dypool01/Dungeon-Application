using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DungeonLibrary;

using DungeonLibrary.Enums;
using MonsterLibrary;

using static System.Formats.Asn1.AsnWriter;

namespace Dungeon
{
    internal class DungeonLabOutline
    {
        

        static void Main(string[] args)
        {
            

            bool end = false;
            int score = 0;
            #region Intro

            //TODO Create exit in intro add ifs and else
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("NEVERQUEST");
            Console.Title = "NEVERQUEST";
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.\n");
            Console.WriteLine();
            Console.ReadKey();


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
                  //  main.Intel = 20;
                  //  main.Wis = 18;
                    break;

                case "2":

                    Console.WriteLine("You've chosen Human");
                    main.PlayerRace = Races.Human;
                    main.MaxLife = 100;
                    main.Life = main.MaxLife;
                    main.Str = 17;
                    main.Dex = 17;
                    main.Con = 17;
                  //  main.Intel = 17;
                  //  main.Wis = 17;
                    break;

                case "3":

                    Console.WriteLine("You've chosen Erudite");
                    main.PlayerRace = Races.Erudite;
                    main.MaxLife = 95;
                    main.Life = main.MaxLife;
                    main.Str = 17;
                    main.Dex = 17;
                    main.Con = 16;
                  //  main.Intel = 19;
                  //  main.Wis = 18;
                    break;

                case "4":

                    Console.WriteLine("You've chosen Iksar");
                    main.PlayerRace = Races.Iksar;
                    main.MaxLife = 115;
                    main.Life = main.MaxLife;
                    main.Str = 18;
                    main.Dex = 20;
                    main.Con = 16;
                  //  main.Intel = 17;
                  //  main.Wis = 19;
                    break;

                case "5":

                    Console.WriteLine("You've chosen Troll");
                    main.PlayerRace = Races.Troll;
                    main.MaxLife = 125;
                    main.Life = main.MaxLife;
                    main.Str = 19;
                    main.Dex = 17;
                    main.Con = 18;
                 //   main.Intel = 16;
                 //   main.Wis = 17;
                    break;

                case "6":

                    Console.WriteLine("You've chosen Ogre");
                    main.PlayerRace = Races.Ogre;
                    main.MaxLife = 150;
                    main.Life = main.MaxLife;
                    main.Str = 20;
                    main.Dex = 15;
                    main.Con = 16;
                  //  main.Intel = 17;
                  //  main.Wis = 19;
                    break;

                default:
                    Console.WriteLine("You have not chosen a playable race.");
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
                    "6. Warrior\n");
            //     "7. Wizard");


            Weapon greataxe = new Weapon(5, 10, "GreatAxe of Rage", 12, true, WeaponType.GreatAxe);




            switch (Console.ReadLine())
            {
                case "1":
                    main.PlayerJob = ClassesEnum.Berserker;
                    main.AC = 17;
                        main.Str += 5;
                        main.Dex += 3;
                        main.Con += 2;
                    //        main.Intel += 3;
                    //        main.Wis += 1;
                    main.EquippedWeapon = greataxe;
                    break;

                case "2":
                    main.PlayerJob = ClassesEnum.Cleric;
                    main.AC = 21;
                          main.Str += 17;
                          main.Dex += 18;
                          main.Con += 18;
                 //         main.Intel += 17;
                 //         main.Wis += 20;
                    break;

                case "3":
                    main.PlayerJob = ClassesEnum.Monk;
                    main.AC = 15;
                          main.Str += 19;
                          main.Dex += 20;
                          main.Con += 18;
                 //         main.Intel += 17;
                 //         main.Wis += 17;
                    break;

                case "4":
                    main.PlayerJob = ClassesEnum.Paladin;
                    main.AC = 23;
                         main.Str += 18;
                         main.Dex += 18;
                         main.Con += 19;
                  //       main.Intel += 16;
                  //       main.Wis += 17;
                    break;

                case "5":
                    main.PlayerJob = ClassesEnum.ShadowKnight;
                    main.AC = 23;
                        main.Str += 18;
                        main.Dex += 18;
                        main.Con += 19;
                  //      main.Intel += 17;
                  //      main.Wis += 16;
                    break;

                case "6":
                    main.PlayerJob = ClassesEnum.Warrior;
                    main.AC = 25;
                         main.Str += 19;
                         main.Dex += 19;
                         main.Con += 20;
                 //       main.Intel += 14;
                 //       main.Wis += 14;
                    break;

              //  case "7":
              //      main.PlayerJob = ClassesEnum.Wizard;
              //      main.AC = 15;
              //      //    main.Str = 15;
              //      //    main.Dex = 16;
              //      //    main.Con = 16;
              //      //    main.Intel = 20;
              //      //    main.Wis = 20;
              //      break;

                default:
                    Console.WriteLine("You have not chosen a playable class");
                    break;
            }//end switch
            #endregion
            Console.Clear();
            do
            {
                
               

                    //3. TODO Create a Room

                    string room = GetRoom();
                    Console.WriteLine(room);

                    //Grab monster for the room

                    Monster monster = Monster.GetMonster();

                    Console.WriteLine("In this room..." + monster.Name);


                    //1. TODO create menu
                    Console.WriteLine("\n" +
                        "A. Attack\n" +
                        "B. Run Away\n" +
                        "C. Character Info\n" +
                        "D. Monster Info\n" +
                        "E. Exit");

                bool reload = false;
                do
                {

                    //2.TODO create switch

                    string choice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();

                    switch (choice)
                    {
                        case "A":
                            //TODO create character properties that give an advantage before battle starts.
                            //ex. if (player.CharacterRace == Race.SuperSpeedyBoi)
                            //{
                            // Combat.DoAttack(player, monster);
                            //)
                            //TODO add functionality for weapon stats
                            Console.WriteLine("Attack");
                            Combat.DoBattle(main, monster);
                            if (monster.Life <= 0)
                            {
                                //IT's DEAD!
                                //Could put logic here to have the player get items, life, or something similar due to beating the monster. Add logic for mini-boss monsters to drop certain weapons
                                score++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster}");
                                //Add EQ coin loot noise here for winning
                                Console.ResetColor();
                                reload = true; //get a new room, and a new monster
                            }//end if
                            if (main.Life <= 0)
                            {
                                Console.WriteLine("Dude.... You died!\a");
                                Console.ForegroundColor= ConsoleColor.Magenta;
                                //Add EQ skeleton laugh here for losing
                                end = true;//leave the entire game
                            }//end if
                            break;//end case A

                        case "B":
                            Console.WriteLine("Run Away");
                            reload = true;
                            break;

                        case "C":
                            Console.WriteLine("Character Info");
                            Console.WriteLine(main);
                            
                            break;

                        case "D":
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;

                        case "E":
                        case "Escape":
                            Console.WriteLine("You are now exiting ");
                            end = true;
                            break;

                        default:
                            Console.WriteLine("There are no cheat buttons");
                            break;
                    }//end switch

                    




                } while (!end && !reload); ; //end do while inner loop


                } while (!end); //end do while outer loop

            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion
        }//end main()
        //GetRoom()
        private static string GetRoom()
        {
            string[] rooms =
            {

               "You have entered a dank basement.",
               "Bones are strewn across the floor of what appears to be a kitchen.",
               "This area is filled with crags and soul fire!",
               "You hear ghostly whispering amongst gravestones.",
               "This dank basement seems familiar.",
               "Is this the same dank basement as before?"
               


            };
            return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom


        


    }//end class
}//end namespace
