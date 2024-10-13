using System;
using System.Collections;
using System.Threading.Tasks.Dataflow;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference();

        //Welcome to the program 
        Console.WriteLine("Welcome to scripture memorizer!");

        Console.Clear();
        Console.WriteLine("Please enter scripture information!");
        //Intro to program and getting of users response.
        Console.Write("Book of scripture; ");
        string book = Console.ReadLine();
        Console.Clear();
        Console.Write("Chapter: ");
        string userInput = Console.ReadLine();
        int chapter = int.Parse(userInput);
        Console.Clear();
        string answer = "";
        do
        {
            Console.Write("Is there multiple verses? (YES/NO) ");
            answer = Console.ReadLine();
            if (answer == "YES")
            {
                Console.Write("Start Verse: ");
                int verse = int.Parse(Console.ReadLine()); 
                Console.Write("What verse will you end on?");
                int endVerse = int.Parse(Console.ReadLine()); 
                reference = new Reference(book, chapter, verse, endVerse);      
            }


            else if (answer == "NO")
            {
                Console.Write("Start Verse: ");
                int verse = int.Parse(Console.ReadLine());        
                //Compiling user responses into a self filling string. 
                reference = new Reference(book, chapter, verse);
            }

        }while (answer != "YES" && answer != "NO");

        Console.Clear();

        Console.Write("Input scripture text: ");
        string text = Console.ReadLine();

        Console.Clear();

        Scripture scripture = new Scripture(reference, text);

        scripture.IsCompletelyHidden();
        string scriptureText = scripture.GetScriptureText();
        Console.WriteLine(scriptureText);
        Console.WriteLine("");
        
        string input = "";
        Console.Clear();
        do
        {
            Console.WriteLine("Enter to eliminate words | Type 'QUIT' to quit program.");
            Console.Write("");
            input = Console.ReadLine();
            Console.WriteLine(scripture.GetScriptureText());
            scripture.HideRandomWords(1);
            Console.Clear();
            scripture.IsCompletelyHidden(); 
        }while (scripture.IsCompletelyHidden() is false && userInput != "QUIT");





    }
}