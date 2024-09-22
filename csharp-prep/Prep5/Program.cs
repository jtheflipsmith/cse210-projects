using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static void PromptUserName(string userName)
        {

            Console.WriteLine($"Hello {userName}");
 
        }


        static int PromptUserNumber(int number)
        {
           
            Console.WriteLine(number);
            return number;

        }

        static double SquareNumber(double number)
        {
            double squared = number * number;
            return squared;
        }

        DisplayWelcome();

        Console.Write("What is your name? ");
        string userName = Console.ReadLine();



        

        Console.Write("Please add your favourite number");
        string favNum = Console.ReadLine();
        int number = int.Parse(favNum); 
        int favNumber = PromptUserNumber(number);


        double finalNumber = SquareNumber(favNumber);

        PromptUserName(userName);

        static void DisplayResults(string name, double finalNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {finalNumber}");
        }

        DisplayResults(userName, finalNumber);

    }
}