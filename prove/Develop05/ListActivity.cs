using System.Net;

public class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    List<string> _responses = new List<string>();

    public ListActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public void Run()
    {
        
        _count = _responses.Count;
        DisplayStartMessage();
        LoadingDisplay(4);
        Console.Write("How much time would you like to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        GetRandomPrompt();
        Thread.Sleep(2000);
        Console.WriteLine("");
        Console.WriteLine("As soon as the timer finishes write as much as you can!");
        Thread.Sleep(1000);
        CountDownTimer(5);
        
        UserList();

        Console.WriteLine("");
        Console.WriteLine($"Response Count: {_count}");
        Thread.Sleep(5000);
        DisplayEndMessage();
        


    }
    public void GetRandomPrompt()
    {
        Random randNum = new Random();
        int number = randNum.Next(_prompts.Count);
        Console.WriteLine(_prompts[number]);
    }

    public void UserList()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        LoadingDisplay(4);
        DateTime currentTime; 
        
        do
        {
            Console.Write("");
            string response = Console.ReadLine();
            _responses.Add(response);
            currentTime = DateTime.Now;

        } while (currentTime < futureTime);
        
        _count = _responses.Count;


    }
}