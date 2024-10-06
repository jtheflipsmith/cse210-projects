using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference();

        //Welcome to the program 
        Console.WriteLine("Welcome to scripture memorizer!");
        Console.WriteLine("Please enter scripture information!");
        //Intro to program and getting of users response.
        Console.Write("Book of scripture; ");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        string userInput = Console.ReadLine();
        int chapter = int.Parse(userInput);
        Console.Write("Is there multiple verses? (YES/NO) ");
        string answer = Console.ReadLine();

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

        else{ Console.WriteLine("Sorry, please type in capitals YES or NO");}


        Console.Write("Input scripture text: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine("Press enter to make words discappear");

        scripture.IsCompletelyHidden();
        string scriptureText = scripture.GetScriptureText();
        Console.WriteLine(scriptureText);
        Console.ReadLine();

        Console.Clear();

        do
        {
            scripture.HideRandomWords(3);
            string hiddenScripture = scripture.GetScriptureText();
            Console.WriteLine(hiddenScripture);
            Console.ReadLine();
            
            Console.Clear();

            scripture.IsCompletelyHidden();
        } while (scripture.IsCompletelyHidden() is false);





    }
}