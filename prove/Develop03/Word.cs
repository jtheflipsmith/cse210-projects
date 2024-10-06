using System.Dynamic;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;

        _isHidden = false;

    }
   
    
    public void HideWord()
    {
        string hidden = "";
        
        for (int i = 0; i < _text.Length; i++)
        {
            hidden += "_";
        }
        
        

        _isHidden  = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}