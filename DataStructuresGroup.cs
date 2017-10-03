//Zach Eddington
/*Write a program in C# using a console application that demonstrates 
the use of a Stack, Queue, and Dictionary (Map). I want you to start 
trying to use GitHub for this assignment.

 Your application will be based around a simple menu. The functionality
 of each menu item is described in more detail below. The first menu
 prompt should be the following:
 
1. Stack
2. Queue
3. Dictionary
4. Exit

If the user chooses #1, display:

1. Add one time to Stack
2. Add Huge List of Items to Stack
3. Display Stack
4. Delete from Stack
5. Clear Stack
6. Search Stack
7. Return to Main Menu

If the user chooses #2, display:

1. Add one time to Queue
2. Add Huge List of Items to Queue
3. Display Queue
4. Delete from Queue
5. Clear Queue
6. Search Queue
7. Return to Main Menu

If the user chooses #3, display:

1. Add one item to Dictionary
2. Add Huge List of Items to Dictionary
3. Display Dictionary
4. Delete from Dictionary
5. Clear Dictionary
6. Search Dictionary
7. Return to Main Menu */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stStackMain = new Stack<string>();
            Stack<string> stStackSave = new Stack<string>();
            Stopwatch swStopWatch = new Stopwatch();
            string sMainSelection;
            string sStackSelection;
            string sQueueSelection;
            string sDictionarySelection;
            string sDeleteSelection;
            string sUserInput;
            bool bValid;
            bool bFound;
            int iCount;
            int iNumDeleted;

            do
            {
                Console.WriteLine("\n1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");
                sMainSelection = Console.ReadLine();
                Console.WriteLine("--------------------");
                do
                {
                    switch (sMainSelection)
                    {
                        case "1":
                            Console.WriteLine("\n1. Add one time to Stack");
                            Console.WriteLine("2. Add Huge List of Items to Stack");
                            Console.WriteLine("3. Display Stack");
                            Console.WriteLine("4. Delete from Stack");
                            Console.WriteLine("5. Clear Stack");
                            Console.WriteLine("6. Search Stack");
                            Console.WriteLine("7. Return to Main Menu");
                            sStackSelection = Console.ReadLine();
                            Console.WriteLine("--------------------\n");
                            do
                            {
                                switch (sStackSelection)
                                {
                                    case "1":
                                        Console.WriteLine("Enter a string to add to the Stack");
                                        stStackMain.Push(Console.ReadLine());
                                        Console.WriteLine("\n" + stStackMain.Count + " item(s) in stack\n");
                                        bValid = true;
                                        break;
                                    case "2":
                                        stStackMain.Clear();
                                        for (iCount = 1; iCount <= 2000; iCount++)
                                        {
                                            stStackMain.Push("New Entry " + iCount);
                                        }
                                        Console.WriteLine("\n" + stStackMain.Count + " item(s) in stack");
                                        bValid = true;
                                        break;
                                    case "3":
                                        if (stStackMain.Count != 0)
                                        {
                                            while (stStackMain.Count > 0)
                                            {
                                                stStackSave.Push(stStackMain.Pop());
                                            }
                                            foreach (string value in stStackSave)
                                            {
                                                Console.WriteLine(value);
                                            }
                                            while (stStackSave.Count > 0)
                                            {
                                                stStackMain.Push(stStackSave.Pop());
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("There are no items in the stack");
                                        }
                                        bValid = true;
                                        break;
                                    case "4":
                                        iNumDeleted = 0;
                                        Console.WriteLine("What value would you like to delete?");
                                        sDeleteSelection = Console.ReadLine();
                                        while (stStackMain.Count > 0)
                                        {
                                            if (stStackMain.Peek() == sDeleteSelection)
                                            {
                                                stStackMain.Pop();
                                                iNumDeleted++;
                                            }
                                            else
                                            {
                                                stStackSave.Push(stStackMain.Pop());
                                            }
                                        }
                                        for (iCount = 0; stStackSave.Count > 0; iCount++)
                                        {
                                            stStackMain.Push(stStackSave.Pop());
                                        }
                                        if (iNumDeleted != 0)
                                        {
                                            Console.WriteLine("\n" + iNumDeleted + " value(s) deleted");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThere were no values that matched your entry");
                                            Console.WriteLine("If you want to delete something, please enter a value contained in the list");
                                        }
                                        bValid = true;
                                        break;
                                    case "5":
                                        Console.WriteLine(stStackMain.Count + " item(s) cleared from stack\n");
                                        stStackMain.Clear();
                                        bValid = true;
                                        break;
                                    case "6":
                                        Console.WriteLine("What value do you want to search for in the Stack?");
                                        sUserInput = Console.ReadLine();
                                        swStopWatch.Start();
                                        bFound = stStackMain.Contains(sUserInput);
                                        swStopWatch.Stop();
                                        if (bFound)
                                        {
                                            Console.WriteLine("\nThe value \"" + sUserInput + "\" was found. It took " + swStopWatch.Elapsed);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThe value \"" + sUserInput + "\" was not found. It took " + swStopWatch.Elapsed);
                                        }
                                        bValid = true;
                                        break;
                                    case "7":
                                        bValid = true;
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease enter a valid input");
                                        sStackSelection = Console.ReadLine();
                                        bValid = false;
                                        break;
                                }
                            } while (bValid == false);
                            if (sStackSelection == "7")
                            {
                                bValid = true;
                            }
                            else
                            {
                                bValid = false;
                            }
                            break;
                        case "2":
                            Console.WriteLine("1. Add one time to Queue");
                            Console.WriteLine("2. Add Huge List of Items to Queue");
                            Console.WriteLine("3. Display Queue");
                            Console.WriteLine("4. Delete from Queue");
                            Console.WriteLine("5. Clear Queue");
                            Console.WriteLine("6. Search Queue");
                            Console.WriteLine("7. Return to Main Menu");
                            sQueueSelection = Console.ReadLine();
                            Console.WriteLine("--------------------\n");
                            do
                            {
                                switch (sQueueSelection)
                                {
                                    case "1":
                                        Console.WriteLine("Enter a string to add to the Queue");
                                        stStackMain.Push(Console.ReadLine());
                                        Console.WriteLine("\n" + stStackMain.Count + " item(s) in stack\n");
                                        bValid = true;
                                        break;
                                    case "2":
                                        stStackMain.Clear();
                                        for (iCount = 1; iCount <= 2000; iCount++)
                                        {
                                            stStackMain.Push("New Entry " + iCount);
                                        }
                                        Console.WriteLine("\n" + stStackMain.Count + " item(s) in stack");
                                        bValid = true;
                                        break;
                                    case "3":
                                        if (stStackMain.Count != 0)
                                        {
                                            while (stStackMain.Count > 0)
                                            {
                                                stStackSave.Push(stStackMain.Pop());
                                            }
                                            foreach (string value in stStackSave)
                                            {
                                                Console.WriteLine(value);
                                            }
                                            while (stStackSave.Count > 0)
                                            {
                                                stStackMain.Push(stStackSave.Pop());
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("There are no items in the stack");
                                        }
                                        bValid = true;
                                        break;
                                    case "4":
                                        iNumDeleted = 0;
                                        Console.WriteLine("What value would you like to delete?");
                                        sDeleteSelection = Console.ReadLine();
                                        while (stStackMain.Count > 0)
                                        {
                                            if (stStackMain.Peek() == sDeleteSelection)
                                            {
                                                stStackMain.Pop();
                                                iNumDeleted++;
                                            }
                                            else
                                            {
                                                stStackSave.Push(stStackMain.Pop());
                                            }
                                        }
                                        for (iCount = 0; stStackSave.Count > 0; iCount++)
                                        {
                                            stStackMain.Push(stStackSave.Pop());
                                        }
                                        if (iNumDeleted != 0)
                                        {
                                            Console.WriteLine("\n" + iNumDeleted + " value(s) deleted");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThere were no values that matched your entry");
                                            Console.WriteLine("If you want to delete something, please enter a value contained in the list");
                                        }
                                        bValid = true;
                                        break;
                                    case "5":
                                        Console.WriteLine(stStackMain.Count + " item(s) cleared from stack\n");
                                        stStackMain.Clear();
                                        bValid = true;
                                        break;
                                    case "6":
                                        Console.WriteLine("What value do you want to search for in the Stack?");
                                        sUserInput = Console.ReadLine();
                                        swStopWatch.Start();
                                        bFound = stStackMain.Contains(sUserInput);
                                        swStopWatch.Stop();
                                        if (bFound)
                                        {
                                            Console.WriteLine("\nThe value \"" + sUserInput + "\" was found. It took " + swStopWatch.Elapsed);
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nThe value \"" + sUserInput + "\" was not found. It took " + swStopWatch.Elapsed);
                                        }
                                        bValid = true;
                                        break;
                                    case "7":
                                        bValid = true;
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease enter a valid input");
                                        sStackSelection = Console.ReadLine();
                                        bValid = false;
                                        break;
                                }
                            } while (bValid == false);
                            if (sStackSelection == "7")
                            {
                                bValid = true;
                            }
                            else
                            {
                                bValid = false;
                            }
                            bValid = true;
                            break;
                        case "3":
                            Console.WriteLine("1. Add one time to Dictionary");
                            Console.WriteLine("2. Add Huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to Main Menu");
                            sDictionarySelection = Console.ReadLine();
                            Console.WriteLine();
                            bValid = true;
                            break;
                        case "4":
                            bValid = true;
                            break;
                        default:
                            Console.WriteLine("\nPlease enter a valid input");
                            sMainSelection = Console.ReadLine();
                            bValid = false;
                            break;
                    }
                } while (bValid == false);
            } while (sMainSelection != "4");
            Console.ReadLine();
        }
    }
}
