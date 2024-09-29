using System.ComponentModel;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{

    public List<string> _prompts = new List<string>();

    public string RandomPrompt()
    {
        Random randNum = new Random();
        int number = randNum.Next(_prompts.Count);
        _prompts.Add("What is one thing you are grateful for today?");
        _prompts.Add("If you could do one thing over today, what would it be?");
        _prompts.Add("How have you seen the hand of the Lord today?");
        _prompts.Add("When was your biggest struggle of the day?");
        _prompts.Add("If there is one peice of advide you would have given to your morning self, what would you advize?");
        string thePrompt = _prompts[number];
        return thePrompt;


    }




    
}

