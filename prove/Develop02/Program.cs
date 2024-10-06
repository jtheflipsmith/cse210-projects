using System;
using System.Xml;
class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.WriteLine("Welcome to the Journal Program!");

        do
        {

            Console.WriteLine("Pick an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please put the number you would like to do: ");
            userInput = Console.ReadLine();
            
            if(userInput == "1" )
            {

                

                Entry prompt = new Entry();
                prompt._promptText.RandomPrompt();

                Entry entry = new Entry();
                entry._dateEntry = dateText;
                Console.WriteLine(prompt);
                entry._promptText = prompt;
                Console.Write("");
                Console.WriteLine("");
                entry._userEntry = Console.ReadLine();
                
                Journal newJournal = new Journal();
                newJournal.AddEntry(entry);
                newJournal.DisplayList();
                
                //Console.Write("Which file would you like to save this in: ");
                //string filePath = Console.ReadLine();
                
            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4");
            {
                Journal journal = new Journal();

            }
            
        }while (userInput !=  "5");

        
    }

}