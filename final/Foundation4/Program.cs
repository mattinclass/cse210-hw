using System;

class Program
{
    static void Main(string[] args)
    {
        Running myRunning = new Running();
        Cycling myCycling = new Cycling();
        Swimming mySwimming = new Swimming();

        myRunning.SetDistance(5);
        myRunning.SetDate("04 January 2023");
        myRunning.SetLength(60);
        myRunning.GetSummary();

        Console.WriteLine();

        myCycling.SetSpeed(20);
        myCycling.SetDate("23 March 2023");
        myCycling.SetLength(30);
        myCycling.GetSummary();

        Console.WriteLine();

        mySwimming.SetLaps(20);
        mySwimming.SetDate("30 August 2023");
        mySwimming.SetLength(45);
        mySwimming.GetSummary();

        Console.WriteLine();
    }
}