using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

public class Scripture
{

    //List holding the split words of the scripture.
    public List<Word> _words = new List<Word>();

    //call to class reference to gain access to the GetDisplayReference() method
    private Reference _reference;


    //Here I believe the text of the scripture will be inserted.
    public Scripture(Reference reference, string text)
    {

        _reference = reference;

        string[] wordList = text.Split(" ");
        foreach (string word in wordList)
        {
            _words.Add(new Word(word));
        }
        
    
    }

    //Get the text from list and compile it into a the string.
    public string GetScriptureText()
    {
        List<string> wordText = new List<string>();

        foreach(Word word in _words)
        {
            wordText.Add(word.GetDisplayText());
        }

        return _reference.GetDisplayReference()+ " " + string.Join(" ", wordText);
    }

    //This will use a for range loop to iterate through the numbers of each item in 
    //List<Word> selecting random numbers using Random. And replacing those words with
    //Underscores.
    public void HideRandomWords(int numberToHide)
    {
        int number = numberToHide;
        if (_words[number].IsHidden())
        {
            Random random = new Random();
            do
            {
                 number = random.Next(_words.Count());

            } while (_words[number].IsHidden());
        }
        _words[number].HideWord();

        
        
    }

    //This method will tell the program if all words are hidden and close the program.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }






}