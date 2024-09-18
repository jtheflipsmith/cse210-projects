using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 20);

        int guess = -1;

        while (guess != number)
        {

            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
  
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Wow! You got it!");
                }
        } 
        
    }
}