public class Entry
{
    public string _dateEntry;
    public string _promptText;
    public string _userEntry;


    public Entry()
    {}

    public void Display()
    {
        Console.WriteLine($"Date: {_dateEntry}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_userEntry}");
        Console.WriteLine("");
    }
}

