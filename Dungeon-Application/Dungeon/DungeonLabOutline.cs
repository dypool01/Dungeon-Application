using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dungeon
{
    internal class DungeonLabOutline
    {
        static void Main(string[] args)
        {
            #region Intro
            Console.WriteLine("DARK DUNGEON");
            Console.Title = "The Dark Dungeon";
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.\n" + 
                "Or press Escape to exit.");
            Console.WriteLine();
            Console.ReadKey();
            #endregion


            #region Player Creation
            Console.WriteLine("What is your name? ");
            Console.WriteLine();
            Character main = new Character();
            main.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("On a scale of 1 to 100 how strong would you like to be? ");
            main.Life = Convert.ToInt32(Console.ReadLine());
            #endregion



            Console.WriteLine();
            

            bool end = false;

            Random rng = new Random();

            int rand = rng.Next(6);

            do
            {

                //TODO Create a Monster

                //TODO Create a Room

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
                        Console.WriteLine("Not a room.");
                        break;
                }//end switch

                bool exit = true;

                bool win = true;

                do
                {
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
                            exit = true;
                            break;

                        case "C":
                            Console.WriteLine("Character Info");
                            Console.WriteLine(main);
                            break;

                        case "D":
                            Console.WriteLine("Monster Info");
                            break;

                        case "E":
                        case "escape":
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
                        Console.WriteLine("Press any key to return to the main menu...");
                        Console.ReadKey();
                        Console.Clear();
                    }//end if
                    
                   
                    

                } while (!exit); //end do while


                } while (!end); //end do while


        }//end main()

    }//end class
}//end namespace
