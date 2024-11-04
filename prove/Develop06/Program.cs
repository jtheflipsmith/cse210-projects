using System;

class Program
{
    static void Main(string[] args)
    {

        // ADDED CREATIVITY: I added the character classes Fighter, and Cleric, for those who like fantasy fun and are having trouble thinking of their own goals
        // These classes add a preset goal list into the users list to work on and have fun with. 
        Console.WriteLine("WELCOME TO ETERNAL QUEST!");
        

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    

    }
}