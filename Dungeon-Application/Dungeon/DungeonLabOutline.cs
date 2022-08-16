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
            Console.WriteLine("DARK DUNGEON");
            Console.Title = "The Dark Dungeon";
            Console.WriteLine();

            Console.WriteLine("CREATE A PLAYER");

            string playerName = Console.ReadLine();

            bool end = false;

            do
            {

                Console.WriteLine("CREATE A MONSTER");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("CREATE A ROOM");
                Console.ReadLine();
                Console.WriteLine();
                
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
                            break;

                        case "B":
                            Console.WriteLine("Run Away");
                            exit = true;
                            break;

                        case "C":
                            Console.WriteLine("Character Info");
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
