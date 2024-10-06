using System.ComponentModel;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{

    public List<string> _prompts = new List<string>();
    {
        "What is one thing you are grateful for today?"
        "If you could do one thing over today, what would it be?"
        "How have you seen the hand of the Lord today?"
        "When was your biggest struggle of the day?"
        "If there is one peice of advide you would have given to your morning self, what would you advize?"

    }


        Random randNum = new Random();
        int number = randNum.Next(_prompts.Count);

    
}

