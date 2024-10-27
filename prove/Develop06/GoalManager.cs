using System.Runtime.CompilerServices;
using System.Security;
using System.Transactions;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Please put which number you would like to do:");
            Console.WriteLine(" 1. Create new Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            //Added creativity
            Console.WriteLine(" 6. Choose a class");
            Console.WriteLine(" 7.Quit");
            Console.Write("");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalInfo();
            }
            else if (choice == "3")
            {
                Console.Write("What is the name of your file?");
                string fileName = Console.ReadLine();
                SaveGoals(_goals, fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the name of your file?");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if (choice == "5")
            {
                //Struggling with recording an event...
                RecordEvent();
            }
            //Added Creativity
            else if (choice == "6")
            {
                //
                LoadCharacterGoals();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Current Score: {_score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
           var goal = _goals[i];
           Console.WriteLine($"{i + 1}. {goal.GetName()}");
        }
    }
    public void ListGoalInfo()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
           var goal = _goals[i];
           Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}.");
        }
    }
    public void CreateGoal()
    {

            Console.WriteLine("Which Type of goal would you like to create?");
            Console.WriteLine(" 1. Simple Goal: One task to finish");
            Console.WriteLine(" 2. Eternal Goal: Consistant through life");
            Console.WriteLine(" 3. CheckList Goal: Needing multiple times to accomplish");
            Console.Write("");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Write a short name for your goal: ");
                string name = Console.ReadLine();
                Console.Write("Please include a brief description: ");
                string description = Console.ReadLine();
                Console.Write("Put ammount of points for this goal here: ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }
            else if (choice == "2")
            {
                Console.Write("Write a short name here: ");
                string name = Console.ReadLine();
                Console.Write("Brief Description: ");
                string description = Console.ReadLine();
                Console.Write("Points for this goal: ");
                int points = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (choice == "3")
            {
                Console.Write("Short name for this goal: ");
                string name = Console.ReadLine();
                Console.Write("Brief description: ");
                string description = Console.ReadLine();
                Console.Write("Points for this goal: ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("Target number for goal to be complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points on full completion");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
            }
        

    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:  ");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        Console.Write("");
        int userResponse = int.Parse(Console.ReadLine());
        
    }
    public void SaveGoals(List<Goal> _goals, string file)
    {

        string fileName = Path.Combine("C:\\Users\\joshu\\cse210\\cse210-projects\\prove\\Develop06\\", $"{file}.txt");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                 string entryDetails = goal.GetStringRepresentation();
                 outputFile.WriteLine(entryDetails);
            }

        }
        Console.WriteLine("Saving to file...");
        Console.WriteLine("");
    }
    public void LoadGoals(string file)
    {
        string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        
        string fileName = Path.Combine(root, $"{file}.txt");
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {

            string[] parts = line.Split(":");
            string className = parts[0].Trim();
            string goal = parts[1].Trim();
            
            if (className == "EternalGoal");
            
        }
    }

    //Added Creativity over and above the project details
    public void LoadCharacterGoals()
    {
        Console.WriteLine("Which class goals would you like to add to your character?");
        Console.WriteLine(" 1. Fighter: Physical Focus");
        Console.WriteLine(" 2. Cleric: Spiritual Focus");
        Console.Write("");
        string decision = Console.ReadLine();

        if (decision == "1")
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string fileName = Path.Combine(root, $"Fighter.txt");

            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {

                string[] parts = line.Split(":");
                string className = parts[0].Trim();
                string goal = parts[1].Trim();

                if (className == "EternalGoal");

            }
        }
        else if (decision == "2");
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string fileName = Path.Combine(root, "Cleric.txt");

            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {

                string[] parts = line.Split(":");
                string className = parts[0].Trim();
                string goal = parts[1].Trim();

                if (className == "EternalGoal");

            }
        }
    }
}
