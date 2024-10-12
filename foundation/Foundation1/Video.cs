using System.Transactions;

public class Video
{
    public List<Comment> _comment = new List<Comment>();
    public string _title;
    public string _author;
    public int _seconds;

    public void VideoDetails()
    {
        Console.WriteLine($"Creator: {_author}");
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Time in seconds: {_seconds}");
        foreach (Comment item in _comment)
        {
            item.Display();
        }
        int count = _comment.Count;
        Console.WriteLine($"{count} comments");
        
    }
}