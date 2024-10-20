public class BreathingActivity : Activity
{
    public BreathingActivity()
    
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Write("How long (in seconds) would you like this activity to go for?");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine($"Get ready..");
        LoadingDisplay(3);
        List<string> words = new List<string>()
        {
            "Breath In...",
            "Hold...",
            "...Breath out",
            "Hold..."
        };

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Thread.Sleep(3000);
        DateTime currentTime;
        do
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
                CountDownTimer(4);
                Console.WriteLine("");
            }

            currentTime = DateTime.Now;

        }while (currentTime < futureTime);
        Console.WriteLine("");
        DisplayEndMessage();

        
    }
}
