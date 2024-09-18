using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        int a = 90;
        int b = 80;
        int c = 70;

        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            if (grade >= 70)
            {
                Console.WriteLine("Congradulations! You Passed!");
            }
            else
            {
                Console.WriteLine("Good effort, however you will have to re-do this course");
            }
                if (grade >= 90)
                {
                    Console.WriteLine($"You did SO good! You got an {letter}");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine($"Looking good! You got a {letter}");
                }
                else if (grade >= 70)
                {
                    Console.WriteLine($"C's get degrees! You got a {letter}");
                }

    }
}