using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int my_Number = -1;

        Console.WriteLine("Type 0 to end the list.");

        while (my_Number != 0)
        {
            Console.WriteLine("Choose a number to add to the list. ");
            my_Number = Int32.Parse(Console.ReadLine());
            numbers.Add(my_Number);
        }

        Console.WriteLine("The list is complete. ");
        int sum = numbers.Sum();
        double average = sum / numbers.Count;
        int largest = 0;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}