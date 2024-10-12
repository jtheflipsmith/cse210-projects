using System.ComponentModel;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Prompt
{

    public Prompt()
    {
        
    }
    public List<string> _prompts = new List<string>()
    {
        "What is something you did today??",
        "What is one thing that you learned?",
        "What is one blessing you can think of from today?",
        "Why is it important to you that today happened?",
        "Can you describe your day in one sentence? Why did you pick that sentence?"

    };


    public string GetRandomPrompt()
    {
        Random randNum = new Random();
        int number = randNum.Next(_prompts.Count);
        string randomPrompt = _prompts[number];
        

        return randomPrompt;
    }
    
}

