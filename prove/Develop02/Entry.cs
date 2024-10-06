public class Entry
{
    public string _dateEntry;
    public Prompt _promptText;
    public string _userEntry;


    public Entry()
    {}

    public void Display()
    {
        Console.WriteLine($"{_dateEntry}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_userEntry}");
        Console.WriteLine("");
    }
}

