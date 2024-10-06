using System.Dynamic;
using System.Security.Cryptography;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(){}
    public Reference(string book, int chapter, int verse)
    {
        _book = book;

        _chapter = chapter;

        _verse = verse;

        _endVerse = -1;
    }
    //Get the book, chapter, verse, and end verse of a scripture.
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // This method combines all relevant information and outputs what is needed.
    public string GetDisplayReference()
    {   
        if (_endVerse == -1)
        {
            string reference = $"{_book} {_chapter}:{_verse}";
             return reference;
        }

        else
        {
            string reference = $"{_book} {_chapter}: {_verse}-{_endVerse}";
            return reference;
        }

    }
}