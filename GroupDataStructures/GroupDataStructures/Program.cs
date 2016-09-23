using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> ourStack = new Stack<string>();
            Queue<string> ourQueue = new Queue<string>();
            Dictionary<string, int> ourDictionary = new Dictionary<string, int>();

            bool notExit = true;
            while (notExit == true)
            {
                notExit = true;
                bool bSubChoice = true;
                int iDictionaryCount = 0;

                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");



                try
                {
                    int iMenuSelect = Convert.ToInt32(Console.ReadLine());


                    if (iMenuSelect == 1)
                    {



                        while (bSubChoice == true)
                        {
                            Console.WriteLine("1. Add one time to Stack\n2. Add Huge List of Items to Stack\n3. Display Stack\n4. Delete from Stack\n5. Clear Stack\n6. Search Stack\n7. Return to Main Menu");

                            try
                            {

                                Console.WriteLine("1. Add one time to Stack\n2. Add Huge List of Items to Stack\n3. Display Stack\n4. Delete from Stack\n5. Clear Stack\n6. Search Stack\n7. Return to Main Menu");

                                int iSubMenu = Convert.ToInt32(Console.ReadLine());


                                if (iSubMenu == 1)
                                {
                                    Console.WriteLine("Enter a string to put on the stack:");
                                    ourStack.Push(Console.ReadLine());

                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 2)
                                {
                                    ourStack.Clear();

                                    for (int iCount = 1; iCount < 2001; iCount++)
                                    {
                                        ourStack.Push("New Entry " + Convert.ToString(iCount));
                                    }

                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();

                                }

                                else if (iSubMenu == 3)
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
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 4)
                                {

                                }

                                else if (iSubMenu == 5)
                                {
                                    ourStack.Clear();
                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 6)
                                {

                                }

                                else if (iSubMenu == 7)
                                {
                                    bSubChoice = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                                }
                            }


                            catch
                            {
                                Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                            }
                        }
                    }

                    else if (iMenuSelect == 2)
                    {
                        while (bSubChoice == true)
                        {
                            Console.WriteLine("1. Add one time to Queue\n2. Add Huge List of Items to Queue\n3. Display Queue\n4. Delete from Queue\n5. Clear Queue\n6. Search Queue\n7. Return to Main Menu");

                            try
                            {

                                Console.WriteLine("1. Add one time to Queue\n2. Add Huge List of Items to Queue\n3. Display Queue\n4. Delete from Queue\n5. Clear Queue\n6. Search Queue\n7. Return to Main Menu");

                                int iSubMenu = Convert.ToInt32(Console.ReadLine());


                                if (iSubMenu == 1)
                                {

                                    Console.WriteLine("Enter a string to put in the queue: ");
                                    ourQueue.Enqueue(Console.ReadLine());

                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();

                                }

                                else if (iSubMenu == 2)
                                {
                                    ourQueue.Clear();

                                    for (int iCount = 1; iCount < 2001; iCount++)
                                    {
                                        ourQueue.Enqueue("New Entry " + Convert.ToString(iCount));
                                    }

                                    Console.WriteLine("Done.");
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 3)
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

                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 4)
                                {

                                }

                                else if (iSubMenu == 5)
                                {

                                    ourQueue.Clear();
                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 6)
                                {

                                }

                                else if (iSubMenu == 7)
                                {
                                    bSubChoice = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                                }
                            }


                            catch
                            {
                                Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                            }
                        }

                    }

                    else if (iMenuSelect == 3)
                    {
                        iDictionaryCount++;
                        while (bSubChoice == true)
                        {
                            Console.WriteLine("1. Add one time to Dictionary\n2. Add Huge List of Items to Dictionary\n3. Display Dictionary\n4. Delete from Dictionary\n5. Clear Dictionary\n6. Search Dictionary\n7. Return to Main Menu");

                            try
                            {

                                Console.WriteLine("1. Add one time to Dictionary\n2. Add Huge List of Items to Dictionary\n3. Display Dictionary\n4. Delete from Dictionary\n5. Clear Dictionary\n6. Search Dictionary\n7. Return to Main Menu");

                                int iSubMenu = Convert.ToInt32(Console.ReadLine());


                                if (iSubMenu == 1)
                                {

                                    Console.WriteLine("Enter a string to add to the dictionary:");
                                    ourDictionary.Add(Console.ReadLine(), iDictionaryCount);
                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();

                                }

                                else if (iSubMenu == 2)
                                {
                                    ourDictionary.Clear();

                                    for (int iCount = 1; iCount < 2001; iCount++)
                                    {
                                        ourDictionary.Add("New Entry " + Convert.ToString(iCount), iCount);
                                    }
                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 3)
                                {
                                    int iDisplayClean = 0;
                                    //write the data from the dictionary
                                    foreach (KeyValuePair<string, int> entry in ourDictionary)
                                    {
                                        iDisplayClean++;
                                        if (iDisplayClean % 5 == 0)
                                            Console.Write("\n" + entry.Key);
                                        else
                                            Console.Write("\t" + entry.Key);
                                    }

                                    Console.ReadLine();
                                }

                                else if (iSubMenu == 4)
                                {

                                }

                                else if (iSubMenu == 5)
                                {
                                    ourDictionary.Clear();
                                    Console.WriteLine("Done.\n\n");
                                    Console.ReadLine();

                                }

                                else if (iSubMenu == 6)
                                {

                                }

                                else if (iSubMenu == 7)
                                {
                                    bSubChoice = false;
                                }

                                else
                                {
                                    Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                                }
                            }


                            catch
                            {
                                Console.WriteLine("Please enter a selection by typing a number (1-7) and pressing ENTER.");
                            }
                        }
                    }

                    else if (iMenuSelect == 4)
                    {
                        notExit = false;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a selection by typing a number (1-4) and pressing ENTER.");
                    }
                }


                catch
                {
                    Console.WriteLine("Please enter a selection by typing a number (1-4) and pressing ENTER.");
                }
            }
        }
    }
}
