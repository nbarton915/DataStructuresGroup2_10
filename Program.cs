/*
 * Nathan Barton Section 002
 * This program has a menu structure consisting of a main menu and a sub menu
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
        static Dictionary<string, int> ourDictionary;
        static Stack<string> ourStack;
        static Queue<string> ourQueue;

        static void Main(string[] args)
        {
            //declare menu variables - NB
            string sChoice = "";//to keep track of menu choices
            bool bMainMenu = true;//used to return to main menu 
            bool bSubMenu = true; //USED TO RETURN TO MAIN MENU... SHOULDN'T ABOVE BE USED TO LEAVE PROGRAM? SW
            Dictionary<int, string> dctStartingMenu = new Dictionary<int, string>();//main menu
            Dictionary<int, string> dctSubMenu = new Dictionary<int, string>();//sub menu


            ourStack = new Stack<string>();
            ourQueue = new Queue<string>();
            ourDictionary = new Dictionary<string, int>();


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
            while (bMainMenu == true)//while main menu is true stay in main menu
            {

                while (sChoice != "1" && sChoice != "2" && sChoice != "3" && sChoice != "4")//move to the next menu if user provides proper input
                {
                    foreach (var menu in dctStartingMenu)//print menu to console via dictionary iteration
                    {
                        //I WOULD SUGGEST HAVING JUST SPACE INSTEAD OF TAB. SW
                        Console.WriteLine(menu.Key + ".\t" + menu.Value);
                    }

                    //for readibility - NB
                    Console.WriteLine();
                    Console.Write("Please select a number > ");
                    sChoice = Console.ReadLine();
                    Console.WriteLine();
                }
                
              
                    
                        foreach (var menu in dctSubMenu)//iterate through submenu
                        {
                            string sValue = "Menu Error";//for error handling & reporting
                            if (dctStartingMenu.TryGetValue(Convert.ToInt32(sChoice), out sValue))
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
                        string sSubChoice = Console.ReadLine();
                        Console.WriteLine();



                       


                


            }
            Console.ReadLine();
        }

        //ADD SINGLE ITEM

        public static void addSingle(string Type)
        {
            switch(Type){
                case "1":
                    {
                        Console.WriteLine("Enter a string to put on the stack:");
                        ourStack.Push(Console.ReadLine());

                        Console.WriteLine("Done.\n\n");
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Enter a string to add to the queue:");
                        ourQueue.Enqueue(Console.ReadLine());

                        Console.WriteLine("Done.\n\n");
                        Console.ReadLine();

                    }
                    break;
                case "3":
                    {
                        int iNewValue = ourDictionary.Count() + 1;
                        Console.WriteLine("Enter a string to add to the dictionary:");
                        ourDictionary.Add(Console.ReadLine(), iNewValue);
                        Console.WriteLine("Done.\n\n");
                        Console.ReadLine();

                    }
                    break;

            }
        }

        //ADD BULK ITEMS

        public static void addBulk(string Type)
        {
            switch (Type)
            {
                case "1":
                    {
                        ourStack.Clear();
                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            ourStack.Push("New Entry " + Convert.ToString(iCount));
                        }
                    }
                    break;
                case "2":
                    {
                        ourQueue.Clear();
                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            ourQueue.Enqueue("New Entry " + Convert.ToString(iCount));
                        }

                    }
                    break;
                case "3":
                    {
                        ourDictionary.Clear();

                        for (int iCount = 1; iCount < 2001; iCount++)
                        {
                            ourDictionary.Add("New Entry " + Convert.ToString(iCount), iCount);
                        }
                        Console.WriteLine("Done.\n\n");
                        Console.ReadLine();

                    }
                    break;

            }
        }
        //DISPLAY ITEMS
        public static void printItems(string Type)
        {
            switch (Type)
            {
                case "1":
                    {
                        int iDisplayClean = 0;
                        foreach (string item in ourStack)
                        {
                            iDisplayClean++;
                            if (iDisplayClean % 5 == 0)
                                Console.Write("\n" + item);
                            else
                                Console.Write("\t" + item);
                        }
                        Console.WriteLine("\n\n");
                    }
                    break;
                case "2":
                    {
                        int iDisplayClean = 0;
                        foreach (string item in ourQueue)
                        {
                            iDisplayClean++;
                            if (iDisplayClean % 5 == 0)
                                Console.Write("\n" + item);
                            else
                                Console.Write("\t" + item);
                        }
                        Console.WriteLine("\n\n");

                    }
                    break;
                case "3":
                    {
                        int iDisplayClean = 0;
                        foreach (KeyValuePair<string, int> item in ourDictionary)
                        {
                            iDisplayClean++;
                            if (iDisplayClean % 5 == 0)
                                Console.Write("\n" + item.Key);
                            else
                                Console.Write("\t" + item.Key);
                        }
                        Console.WriteLine("\n\n");

                    }
                    break;

            }
            


        }

        //DELETE SINGLE ITEM


        //CLEAR DATA STRUCTURE

        public static void clearData(string Type)
        {
            //Type.Clear();
            Console.WriteLine("Done.\n\n");
        }

        //SEARCH DATA STRUCTURE


        //RETURN TO MAIN MENU

        public static void toMain()
        {
            //change bSubMenu to false
        }



    }

}
