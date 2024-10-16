using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joshua Smith", "Computer Science");
        Console.WriteLine(assignment.GetSummery());
        Console.WriteLine("");
        MathAssignment mathAssignment = new MathAssignment("Tony Remirez", "Math", "Section 8.2", "Problems 8-34");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");
        WritingAssignment writingAssignment = new WritingAssignment("Zoey Gonzalas", "History", "War and Peace by...");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}