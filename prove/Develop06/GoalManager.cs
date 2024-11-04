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
        while (choice != "7")
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
            Console.WriteLine(" 7. Quit");
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
        // Do some user error checking
        int userResponse = int.Parse(Console.ReadLine());
        _goals[userResponse - 1].RecordEvent();
        int addedScore = _goals[userResponse - 1].GetPoints();
        _score += addedScore;

        
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
        // (setting i to 0; telling i to stop at the end of lines, iterated through lines one at a time.)
        for (int i = 0; i < lines.Length; i++)
        {
            // Skipping first line and setting _score.
            if (i == 0)
            {
                // Adding first line into _score to mark the points
                int.TryParse(lines[0], out _score);
            }
            else
            {
                string[] parts = lines[i].Split(":");
                string className = parts[0].Trim();
                //To do: Should we handle impropper case in this program?
                if (className == "SimpleGoal")
                {
                    if (parts.Length <= 1)
                    {
                        continue;
                    }
                    string[] goalParts = parts[1].Split(",");
                    //Choosing to ignore bad formatted goals
                    if (goalParts.Length < 3)
                    {
                        continue;
                    }

                    SimpleGoal simple = new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                    _goals.Add(simple);    
                }
                else if (className == "EternalGoal")
                {
                    if (parts.Length <= 1)
                    {
                        continue;
                    }
                    string[] goalParts = parts[1].Split(",");
                    //Choosing to ignore bad formatted goals
                    if (goalParts.Length < 3)
                    {
                        continue;
                    }

                    EternalGoal eternal = new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                    _goals.Add(eternal);
                }
                else if (className == "ChecklistGoal")
                {
                    if (parts.Length <= 1)
                    {
                        continue;
                    }
                    string[] goalParts = parts[1].Split(",");
                    //Choosing to ignore bad formatted goals
                    if (goalParts.Length < 3)
                    {
                        continue;
                    }

                    ChecklistGoal checklist = new ChecklistGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]), int.Parse(goalParts[3]), int.Parse(goalParts[4 ]) );
                    _goals.Add(checklist);
                }
                
            }
            

            
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
            Console.WriteLine("Welcome Fighter! Your new goals should now be in your que");
            LoadGoals("Fighter");
        }
                    
        else if (decision == "2")
        {
            Console.WriteLine("Ah, a new cleric! We have added your assignments to your que");
            LoadGoals("Cleric");
        }
    }
}

