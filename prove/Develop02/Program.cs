using System;
using System.Xml;
class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.WriteLine("Welcome to the Journal Program!");

        while (userInput !=  "5")
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
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                

                Prompt prompt = new Prompt();
                string newPrompt = prompt.RandomPrompt();

                Entry entry = new Entry();
                entry._dateEntry = dateText;
                Console.WriteLine(newPrompt);
                entry._promptText = newPrompt;
                Console.Write("");
                Console.WriteLine("");
                entry._userEntry = Console.ReadLine();
                entry.Display();
                

                
            }
            else if (userInput == "2")
            {
                
            }
            else if (userInput == "3")
            {
                Journal save = new Journal();
                save.SaveFile();
            }
            
        }

        
    }

}