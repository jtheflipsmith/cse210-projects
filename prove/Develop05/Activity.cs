public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Meditation";
        _description = "Please pick an option:\n 1. Breathing Activity\n 2. Reflection Activity\n 3. Listing Activity\n 4.Ponder Activity2";
        _duration = -1;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        LoadingDisplay(3);
        Console.WriteLine(_description);
        

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"Thank you for participating in the {_name} activity!");
    }
    public void LoadingDisplay(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime;
        do
        {
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400); 
            Console.Write("\b\b\b   \b\b\b");
            Thread.Sleep(200);      

            currentTime = DateTime.Now;
        } while (currentTime < futureTime);


    }
    public void CountDownTimer(int number)
    {

        for(int i = number ; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }

    public void SpinnerDisplay()
    {
        List<string> spinner = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        };

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(15);
        DateTime currentTime;
        do
        {
            foreach(string symbol in spinner)
            {
                Console.Write(symbol);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }

            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
    }



}