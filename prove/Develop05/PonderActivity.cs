using System.Net.Sockets;

public class PonderActivity : Activity
{
    List<string> _scripture;
    List<string> _questions;
    List<string> _userResponse = new List<string>();

    public PonderActivity()
    {
        _name = "Ponder";
        _description = "Take a moment to look over a scripture about how God sees you, think about the words in the scripture and write a quick thought about how it makes you feel.\n\nWhen finished type 'QUIT'";
        
        _scripture = new List<string>()
        {
            "Jerimiah 31:3 - The Lord hath appeared of old unto me, saying, Yea, I have loved thee with an everlasting love: therefore with lovingkindness have I drawn thee.",
            "John 3:16 - For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "1 John 4:7 - Beloved, let us love one another: for love is of God; and every one that loveth is born of God, and knoweth God.",
            "D&C 95:1 - Verily, thus saith the Lord unto you whom I love, and whom I love I also chasten that their sins may be forgiven, for with the chastisement I prepare a way for their deliverance in all things out of temptation, and I have loved you."
        };
        _questions = new List<string>()
        {
            "How does what is said make you feel?",
            "What do you feel is Gods view of you?",
            "How can you return the feelings you have to God?",
            "Who are you in God's eyes?",
            "When have you felt Gods love the most?",
            "What do you feel like doing after reading this?"
        };
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine();
        DisplayScripture();
        Console.WriteLine("");
        string userResponse;
        do
        {
            DisplayQuestion();
            Console.Write("");
            userResponse = Console.ReadLine();
            AddResponse(userResponse); 
        }while (userResponse != "QUIT");
        
        DisplayEndMessage();
    }

    public string RandomScripture()
    {
        Random randNum = new Random();
        int number = randNum.Next(_scripture.Count);
        string randomQuestion = _scripture[number];
        

        return randomQuestion;
    }
    public string randomQuestion()
    {
        Random randNum = new Random();
        int number = randNum.Next(_questions.Count);
        string randomQuestion = _questions[number];
        

        return randomQuestion;
    }
    public void DisplayScripture()
    {
        Console.WriteLine(RandomScripture());
    }
    public void DisplayQuestion()
    {
        Console.WriteLine(randomQuestion());
    }

    public void AddResponse(string userResponse)
    {

        _userResponse.Add(userResponse);
    }
}