using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Added a ponder activity to blend more spirit into a reflective experience
        int endProgram = 0;
        do
        {
            Activity activity = new Activity();
            activity.DisplayStartMessage();
            Console.Write("");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {//
                //Console.Write("How much time would you like to spend on this activity?");
                //int duration = int.Parse(Console.ReadLine());
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.DisplayStartMessage();
                Thread.Sleep(6000);
                breathing1.Run();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();

            }
            else if (choice == 3)
            {
                ListActivity listing = new ListActivity();
                listing.Run(); 
            }
            else if (choice == 4)
            {
                PonderActivity ponder = new PonderActivity();
                ponder.Run();
            }
            else if (choice == 5)
            {
                Activity fun = new Activity();
                fun.SpinnerDisplay();
            }
            else
            {
                Console.WriteLine("Sorry, I didn't get that...");
            }
            Console.WriteLine("1 - Again");
            Console.WriteLine("2 - Quit");
            Console.Write("");
            endProgram = int.Parse(Console.ReadLine());
        }while (endProgram != 2);
        

    }
}