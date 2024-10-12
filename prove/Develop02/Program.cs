using System;
using System.IO.Enumeration;
using System.Xml;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello! Welcome to the journal program!");
        Console.WriteLine("Lets get started, shall we?");
        Journal journal1 = new Journal();
        string userChoice = "";
        do
        {

            journal1.DisplayList();
            Console.Write("Put the number of what you want to do here:");

            userChoice = Console.ReadLine();  

            if (userChoice == "1") 
            {
                Entry newEntry = new Entry();
                journal1.AddEntry(newEntry);
                Console.WriteLine("");
                
            }     
            else if (userChoice == "2")
            {
                journal1.DisplayAll();
                Console.WriteLine("");
            }
            else if (userChoice == "3")
            {

                Console.Write("What is the file you would like to load?: ");
                string loadFile = Console.ReadLine();
                journal1.LoadFile(loadFile);
            }
            else if (userChoice == "4")
            {
                Console.Write("File Name: ");
                string saveFile = Console.ReadLine();
                journal1.SaveFile(saveFile);
            }

        } while (userChoice != "5");
    
    }

}