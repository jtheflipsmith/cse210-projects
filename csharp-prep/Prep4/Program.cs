using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Unlike Python, C-sharp must specify the TYPE of list it is.
        List<int> numbers = new List<int>();

        Console.WriteLine("Add numbers to the numbers list. When you are finished write the number 0");

        int newNumber = -1;

        while (newNumber != 0)
        {
             Console.Write("Add number: ");
             newNumber = int.Parse(Console.ReadLine());
             numbers.Add(newNumber);

        }
        // Counting and listing the total number of items within the list.
        Console.WriteLine($"The sum is: {numbers.Count}");

        double average = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The average is {average}");

        double max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}