using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture myLecture = new Lecture();
        myLecture.SetSpeaker("Tony Johnson");
        myLecture.SetCapacity(400);
        myLecture.SetTitle("Special Speaking Event");
        
        myLecture.SetDate("June 30, 2023");
        myLecture.theAddress.SetAddress("2040 Moody Way", "Chicago", "Illinois", "USA");
        myLecture.SetTime("6:00PM");
        myLecture.GenerateStandardDetails();
        Console.WriteLine();
        myLecture.GenerateFullDetails();
        Console.WriteLine();
        myLecture.GenerateShortDescription();
        Console.WriteLine();


        Reception myReception = new Reception();
        myReception.SetTitle("Celebrating our Wedding");
        myReception.SetDate("August 6th, 2023");
        myReception.SetEmail("mollyjb40@gmail.com");
        myReception.theAddress.SetAddress("245 N 3rd W","Windyville", "Arkansas", "USA");
        myReception.SetTime("6:30PM");
        myReception.GenerateStandardDetails();
        Console.WriteLine();
        myReception.GenerateFullDetails();
        Console.WriteLine();
        myReception.GenerateShortDescription();
        Console.WriteLine();

        Outdoor myOutdoor = new Outdoor();
        myOutdoor.SetTitle("Annual Contractors' Potluck");
        myOutdoor.SetDate("July 3rd, 2023");
        myOutdoor.SetTime("7:00PM");
        myOutdoor.theAddress.SetAddress("East City Park, 2nd N St.", "Moscow", "Idaho", "USA");
        myOutdoor.SetWeather("sunny");
        myOutdoor.GenerateStandardDetails();
        Console.WriteLine();
        myOutdoor.GenerateFullDetails();
        Console.WriteLine();
        myOutdoor.GenerateShortDescription();
    }
}