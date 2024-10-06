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
    
        _text = new string("_", _text.Length);
        

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