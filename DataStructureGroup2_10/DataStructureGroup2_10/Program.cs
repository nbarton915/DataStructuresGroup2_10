/*
 * Nathan Barton Section 002
 * This program has a menu structure consisting of a main menu and a sub menu. Each sub menu has a different functionality
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureGroup2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare menu variables - NB
            string sChoice = "";//to keep track of menu choices
            bool bMainMenu = true;//used to return to main menu
            Dictionary<int, string> dctStartingMenu = new Dictionary<int,string>();//main menu
            Dictionary<int, string> dctSubMenu = new Dictionary<int, string>();//sub menu

            //create the main menu - NB
            dctStartingMenu.Add(1, "Stack");
            dctStartingMenu.Add(2, "Queue");
            dctStartingMenu.Add(3, "Dictionary");
            dctStartingMenu.Add(4, "Exit");

            //create the sub menu - NB 
            dctSubMenu.Add(1, "Add one item to");
            dctSubMenu.Add(2, "Add Huge List of Items to");
            dctSubMenu.Add(3, "Display");
            dctSubMenu.Add(4, "Delete From");
            dctSubMenu.Add(5, "Clear");
            dctSubMenu.Add(6, "Search");
            dctSubMenu.Add(7, "Return to Main Menu");

            //Display menues - NB
            while(bMainMenu == true)//while main menu is true stay in main menu
            { 
                while (sChoice != "1" && sChoice != "2" && sChoice != "3" && sChoice != "4")//move to the next menu if user provides proper input
                {
                    foreach (var menu in dctStartingMenu)//print menu to console via dictionary iteration
                    {
                        Console.WriteLine(menu.Key + ".\t" + menu.Value);
                    }

                    //for readibility - NB
                    Console.WriteLine();
                    Console.Write("Please select a number > ");
                    sChoice = Console.ReadLine();
                    Console.WriteLine();
                }
                        //switch where case is user's choice to main menu - NB
                        switch (sChoice)
                        {
                                // for menu item 1 (stack) - NB 
                            case "1":
                                foreach (var menu in dctSubMenu)//iterate through submenu
                                {
                                    string sValue = "Menu Error";//for error handling & reporting
                                    if (dctStartingMenu.TryGetValue(1, out sValue))
                                    {
                                        Console.WriteLine(menu.Key + ".\t" + menu.Value + " " + sValue);//print submenu to console
                                        bMainMenu = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine(sValue);
                                        bMainMenu = false;
                                    }
                                }
                                //for readibility - NB
                                Console.WriteLine();
                                Console.Write("Please select a number > ");
                                sChoice = Console.ReadLine();
                                Console.WriteLine();

                                while (sChoice != "1" && sChoice != "2" && sChoice != "3" && sChoice != "4" && sChoice != "5" && sChoice != "6")//move to the step if user provides proper input
                                {

                                }
                                break;
                            // for menu item 2 (Queue) - NB
                            case "2":
                                {
                                    foreach (var menu in dctSubMenu)//iterate through submenu
                                    {
                                        string sValue = "Menu Error";//for error handling & reporting
                                        if (dctStartingMenu.TryGetValue(2, out sValue))
                                        {
                                            Console.WriteLine(menu.Key + ".\t" + menu.Value + " " + sValue);//print submenu to console
                                            bMainMenu = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine(sValue);
                                        }
                                    }
                                    break;
                                }
                            // for menu item 3 (Dictionary) - NB
                            case "3":
                                {
                                    foreach (var menu in dctSubMenu)//iterate through submenu
                                    {
                                        string sValue = "Menu Error";//for error handling & reporting
                                        if (dctStartingMenu.TryGetValue(2, out sValue))
                                        {
                                            Console.WriteLine(menu.Key + ".\t" + menu.Value + " " + sValue);//print submenu to console
                                            bMainMenu = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine(sValue);
                                        }
                                    }
                                    break;
                                }
                            default: break;


                        }
            
                
            }
            Console.ReadLine();
        }
    }
}
