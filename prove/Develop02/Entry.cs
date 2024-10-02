public class Entry
{
    public string _dateEntry;
    public Prompt _promptText;
    public string _userEntry;


    public void Display()
    {
        Console.WriteLine($"{_dateEntry}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_userEntry}");
    }
}

