using System;

class Program
{
    static void Main(string[] args)
    {
        // Still trying to figure out how to load the specific goal types
        // back into the list from the text file. 

        // Need to figure out how to replace checkboxes with filled in x's 

        // Adding points and connecting them to the player total needs to be done.

        // --- MY ADDED CREATIVITY FOR THIS ASSIGNMENT IS TO INTRODUCE CHARACTER 
        // CLASSES WITH UNIQUE GOALS SPECIFIC TO THEM --- 
        Console.WriteLine("WELCOME TO ETERNAL QUEST!");
        

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    

    }
}