using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        bool is_Correct = false;

        while (is_Correct == false)
        {

            Console.WriteLine("What is your guess? ");
            int guess = Int32.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("Good Job!");
                is_Correct = true;
            }
        }


    }
}