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
        static Queue<string> ourNewQueue = new Queue<string>();
        static Stack<string> ourNewStack = new Stack<string>();

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
                sChoice = "";
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
                    if (sChoice.Equals("4"))
                    {
                        bMainMenu = false;
                    }
                }


                while (bSubMenu == true)
                {
                    foreach (var menu in dctSubMenu)//iterate through submenu
                    {
                        string sValue = "Menu Error";//for error handling & reporting
                        if (dctStartingMenu.TryGetValue(Convert.ToInt32(sChoice), out sValue))
                        {
                            Console.WriteLine(menu.Key + ".\t" + menu.Value + " " + sValue);//print submenu to console                            
                        }
                        else
                        {
                            Console.WriteLine(sValue);
                            bSubMenu = false;
                        }

                    }




                    //for readibility - NB
                    Console.WriteLine();
                    Console.Write("Please select a number > ");
                    string sSubChoice = Console.ReadLine();
                    Console.WriteLine();
                    switch (sSubChoice)
                    {
                        case "1":
                            {
                                addSingle(sChoice);
                                Console.WriteLine("\nDone.\n\n");
                            }
                            break;

                        case "2":
                            {
                                addBulk(sChoice);
                                Console.WriteLine("\nDone.\n\n");
                            }
                            break;

                        case "3":
                            {
                                printItems(sChoice);
                                Console.WriteLine("\nDone.\n\n");
                            }
                            break;

                        case "4":
                            {
                                singleDelete(sChoice);
                            }
                            break;

                        case "5":
                            {
                                clearData(sChoice);
                                Console.WriteLine("\nDone.\n\n");
                            }
                            break;

                        case "6":
                            {
                                searchStructure(sChoice);
                            }
                            break;

                        case "7":
                            {
                                bSubMenu = false;
                            }
                            continue;

                    }
                }
            }

        }

        //ADD SINGLE ITEM

        public static void addSingle(string Type)
        {
            switch (Type)
            {
                case "1":
                    {
                        Console.WriteLine("Enter a string to put on the stack:");
                        ourStack.Push(Console.ReadLine());
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("Enter a string to add to the queue:");
                        ourQueue.Enqueue(Console.ReadLine());
                    }
                    break;
                case "3":
                    {
                        int iNewValue = ourDictionary.Count() + 1;
                        Console.WriteLine("Enter a string to add to the dictionary:");
                        ourDictionary.Add(Console.ReadLine(), iNewValue);
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
                            else if (iDisplayClean == 1)
                                Console.Write("\n" + item);
                            else if (ourStack.Count <= 5)
                                Console.WriteLine(item);
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
                            else if (iDisplayClean == 1)
                                Console.Write("\n" + item);
                            else if (ourQueue.Count <= 5)
                                Console.WriteLine(item);
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
                            else if (iDisplayClean == 1)
                                Console.Write("\n" + item);
                            else if (ourDictionary.Count <= 5)
                                Console.WriteLine(item);
                            else
                                Console.Write("\t" + item.Key);
                        }
                        Console.WriteLine("\n\n");

                    }
                    break;

            }



        }

        //DELETE SINGLE ITEM
        public static void singleDelete(string Type)
        {
            switch (Type)
            {
                case "1":
                    {

                        string StackDelete;
                        string CopyStack;
                        int iCount = 0;
                        bool StackTester = true;
                        Console.WriteLine("What Stack Item would you like to delete?");
                        StackDelete = Console.ReadLine();

                        while (StackTester == true)
                        {

                            if (StackDelete.Equals(ourStack.Peek()))
                            {
                                StackDelete = ourStack.Pop();
                                Console.WriteLine(StackDelete + " was deleted.");
                                StackTester = false;
                            }
                            else
                            {
                                CopyStack = ourStack.Pop();
                                ourNewStack.Push(CopyStack);
                                iCount = iCount + 1;
                            }
                        }
                        for (int i = 0; i < iCount; i++ )
                        {
                            CopyStack = ourNewStack.Pop();
                            ourStack.Push(CopyStack);
                        }
                    }
                    break;

                case "2":
                    {
                        string QueueDelete;
                        string TempQueue;
                        bool QueueTester = true;
                        int iCount2 = 0;
                        Console.WriteLine("What Queue Item would you like to delete?");
                        QueueDelete = Console.ReadLine();
                        while (QueueTester == true)
                        {
                            if (QueueDelete.Equals(ourQueue.Peek()))
                            {
                                ourQueue.Dequeue();
                                Console.WriteLine(QueueDelete + " was deleted.");
                                QueueTester = false;
                            }
                            else
                            {
                                TempQueue = ourQueue.Dequeue();
                                ourNewQueue.Enqueue(TempQueue);
                            }
                        }
                        for (int i = 0; i < ourNewQueue.Count();i++ )
                        {
                            TempQueue = ourNewQueue.Dequeue();
                            ourQueue.Enqueue(TempQueue);
                        }
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("What Dictionary Item would you like to delete?");
                        string DictionaryItem = Console.ReadLine();
                        if (ourDictionary.ContainsKey(DictionaryItem))
                        {
                            ourDictionary.Remove(DictionaryItem);
                            Console.WriteLine(DictionaryItem + " was removed from Dictionary.");
                        }
                        else
                        {
                            Console.WriteLine(DictionaryItem + " was not found.");
                        }


                    }
                    break;
            }
        }
        //CLEAR DATA STRUCTURE

        public static void clearData(string Type)
        {
            switch (Type)
            {
                case "1":
                    {
                        ourStack.Clear();
                    }
                    break;
                case "2":
                    {
                        ourQueue.Clear();
                    }
                    break;
                case "3":
                    {
                        ourDictionary.Clear();
                    }
                    break;

            }
        }

        //SEARCH DATA STRUCTURE
        public static void searchStructure(string Type)
        {
            string sItem = null;
            switch (Type)
            {
                case "1":
                    ourNewStack = new Stack<string>();
                    Console.Write("What stack item are you looking for? ");
                    sItem = Console.ReadLine();
                    foreach (string Item in ourStack)
                    {
                        if (Item.Equals(sItem))//if it matches the stack item display the match
                        {
                            Console.WriteLine(ourStack.Peek() + " was found in the stack.");
                            ourNewStack.Push(ourStack.Pop());//push to the temp stack and pop off the original stack
                        }
                        else
                        {
                            ourNewStack.Push(ourStack.Pop());//push to the temp stack and pop off the original stack
                        }

                    }
                    foreach (string Item in ourNewStack)//put stack items from temp stack back into original stack
                    {
                        ourStack.Push(ourNewStack.Pop());
                    }
                    break;
                case "2":
                    ourNewQueue = new Queue<string>();
                    Console.Write("What queue item are you looking for? ");
                    sItem = Console.ReadLine();
                    foreach (string Item in ourQueue)
                    {
                        if (sItem.Equals(Item))
                        {
                            Console.WriteLine(ourQueue.Peek() + " was found in the queue.");
                            ourNewQueue.Enqueue(ourQueue.Dequeue());
                        }
                        else
                        {
                            ourNewQueue.Enqueue(ourQueue.Dequeue());
                        }
                    }
                    foreach (string Item in ourNewQueue)
                    {
                        ourQueue.Enqueue(ourNewQueue.Dequeue());
                    }
                    break;
                case "3":
                    Console.Write("What dictionary item are you looking for? ");
                    sItem = Console.ReadLine();
                    if (ourDictionary.ContainsKey(sItem))
                    {
                        Console.WriteLine(sItem + " was found in the dictionary.");
                    }
                    else
                    {
                        Console.WriteLine(sItem + " was not found in the dictionary.");
                    }
                    break;
            }
        }
    }
}
