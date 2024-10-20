public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>()
        {
           "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "Is there anyone you were able to share this experience with?",
            "How might it have changed your perspective?",
            "Is there other ways to create this in your future?"
        };

    }

    public void Run()
    {
        DisplayStartMessage();
        LoadingDisplay(10);
        Console.WriteLine("");
        Console.Write("How much time would you like to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());
        
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        LoadingDisplay(4);
        DateTime currentTime;
        do
        {
            DisplayQuestion();
            LoadingDisplay(8);
            Console.WriteLine("");
            currentTime = DateTime.Now;

        } while (currentTime < futureTime);
        Console.WriteLine("");
        DisplayEndMessage();
    }

    public string GetRandomPrompt()
    {
        Random randNum = new Random();
        int number = randNum.Next(_prompts.Count);
        string randomPrompt = _prompts[number];
        

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randNum = new Random();
        int number = randNum.Next(_questions.Count);
        string randomQuestion = _questions[number];
        

        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}