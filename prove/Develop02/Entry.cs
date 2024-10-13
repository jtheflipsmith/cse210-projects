public class Entry
{
    public string _dateEntry;
    public string _promptText;
    public string _userEntry;
    //ADDED: User gets to add a summary of the day.
    public string _freeEntry;


    public Entry()
    {}

    public void Display()
    {
        Console.WriteLine($"Date: {_dateEntry}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_userEntry}");
        Console.WriteLine("");
    }

    //ADDED: Summery method to entry class.
    public void Summary()
    {
        Console.WriteLine($"Date: {_dateEntry}");
        Console.WriteLine(_freeEntry);
    }
}

